import sys
import ECG_Preprocessing as ECG
import Classification_Model as classification
import wfdb
#sig = ECG.Read_Signal( signalPath='mit-bih-arrhythmia-database-1.0.0/100')  #will Remove This Line

#signal_path = sys.argv[1]
signal_path = r'F:\Faculty of Computers and Informatics\4th Year\Graduation Project\Preprocessing\Coding\mitdb\214'
print(signal_path)
sig = ECG.Read_Signal( signalPath=signal_path)
# @ Write Signal TXT @ #
ECG.Write_txt(file_name='Signal.txt' , Data=sig)
# @ Write Filtered_Signal TXT @ #
filteredSig = ECG.butter_bandpass_filter(sig, 0.5, 40, 300, 2)
filteredSig = ECG.normalized(filteredSig)
ECG.Write_txt(file_name='Filtered_Signal.txt' , Data=filteredSig)

# @ Write QRS Restults in R_peaks TXT @ #
qrs_inds = ECG.processing.xqrs_detect(sig=filteredSig[:, 0], fs=360)
ECG.Write_txt(file_name='R_Peaks.txt' , Data=qrs_inds)
print(list(qrs_inds))
# @ Write Dynamic Segmentation Results in Beats TXT @ #
beats = ECG.DynamicSegmentation(qrs_inds,filteredSig)
beats = ECG.resampling(beats, 300)
ECG.Write_txt(file_name='beats.txt' , Data=beats)

# @ Write Classification Results for Each Beat in beats_Classes TXT @ #
labels = classification.Classify_Beats(beats)
print(list(labels))
ECG.Write_txt(file_name='beats_Classes.txt' ,Data=list (labels))
print('Finished Successfuly')

