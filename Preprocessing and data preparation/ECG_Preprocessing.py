

import numpy as np
import wfdb
import cv2
from wfdb import processing

from scipy.signal import butter, lfilter
from IPython.display import display
import matplotlib.pyplot as plt
from preprocessing import *

from scipy.signal import freqz
from scipy import signal

def butter_bandpass(lowcut, highcut, fs, order=5):
    nyq = 0.5 * fs
    low = lowcut / nyq
    high = highcut / nyq
    b, a = butter(order,[low, high], btype='bandpass')
    return b, a

def butter_bandpass_filter(data, lowcut, highcut, fs, order=5):
    b, a = butter_bandpass(lowcut, highcut, fs, order=order)
    y = lfilter(b, a, data,axis=0)
    return y


def normalized(sig):
    normalized_sig = (sig - min(sig)) / (max(sig) - min(sig))
    return normalized_sig


def DynamicSegmentation(peaksIndecies,signal):
    beats = [[]]
    beats.remove([])
    for i in range(1,len(peaksIndecies)-1):
        RRPrev = peaksIndecies[i] - peaksIndecies[i-1]
        RRNext = peaksIndecies[i+1] - peaksIndecies[i]
        RRMax = max(RRPrev, RRNext)
        start = peaksIndecies[i]- int((1/3.0)*RRMax)
        end = peaksIndecies[i] + int((2 / 3.0 )* RRMax)
        beats.append(signal[start:end])
    return beats

def Read_Signal( signalPath):
    record = wfdb.rdrecord(signalPath)
    annotation = wfdb.rdann(signalPath, 'atr')
    print(annotation.symbol)
    print(annotation.sample)
    sig, fields = wfdb.rdsamp(signalPath, channels=[0])
    return sig

def resampling(beats,samprate):
    resampled = [[]]
    resampled.remove([])
    for i in beats:
        resampled.append(list(signal.resample(i,samprate)))
    return resampled

def PreProcessing(signal,fs = 360, datasetinds = None):

    filteredSig = butter_bandpass_filter(signal, 0.5, 40, 300, 2)
    filteredSig = normalized(filteredSig)

    if datasetinds == None:
        qrs_inds = processing.xqrs_detect(sig=filteredSig[:, 0], fs=fs)

        beats = DynamicSegmentation(qrs_inds,filteredSig)
    else:
        beats = DynamicSegmentation(datasetinds,filteredSig)
    beats = resampling(beats,300)

    return beats

def Write_txt (file_name = None , Data = None ) :
    w = open(file_name, 'w')
    l = list()
    if file_name == 'beats.txt' :
        for i in range(len(Data)):
            for j in range(len(Data[i])):
                w.write(str(Data[i][j][0]) + '|')
            w.write('\n')

    elif file_name == 'beats_Classes.txt' :
        for e in Data:
            l.append(str(e) + '|')
        w.writelines(l)

    elif file_name == 'R_Peaks.txt' :
        for i in range(1,len(Data)-1):
            l.append(str(Data[i]) + '|')
        w.writelines(l)
    else: #Signal or Filter Signal
        for e in Data:
            l.append(str(e[0]) + '|')
        w.writelines(l)

    w.close()


#sig = Read_Signal( signalPath='mit-bih-arrhythmia-database-1.0.0/100')


#beats = PreProcessing(sig)
#print (len (beats))
