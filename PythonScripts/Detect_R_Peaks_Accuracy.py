from ECG_Preprocessing import *
def calcRPeaksDiff(AlgorithmRPeaks,DatasetRPeaks):
    j = 0
    diff = []
    if len(AlgorithmRPeaks) >= len(DatasetRPeaks):
        for i in range(len(DatasetRPeaks)):
            if j == len(AlgorithmRPeaks):
                break
            foundSyn = 0
            if(abs(AlgorithmRPeaks[j] - DatasetRPeaks[i]) > 50):
                for h in range(i+1,len(AlgorithmRPeaks)):
                    if (abs(AlgorithmRPeaks[h] - DatasetRPeaks[i]) > 50):
                        continue
                    else:
                        foundSyn = 1
                        j = h
                        break
                if foundSyn == 0:
                    continue


            dif = abs(AlgorithmRPeaks[j]-DatasetRPeaks[i])
            diff.append(dif)
            j+=1
    elif len(AlgorithmRPeaks) < len(DatasetRPeaks):
        for i in range(len(AlgorithmRPeaks)):
            if j == len(DatasetRPeaks):
                break
            foundSyn = 0
            if (abs(AlgorithmRPeaks[i] - DatasetRPeaks[j]) > 50):
                for h in range(i + 1, len(DatasetRPeaks)):
                    if (abs(AlgorithmRPeaks[i] - DatasetRPeaks[h]) > 50):
                        continue
                    else:
                        foundSyn = 1
                        j = h
                        break
                if foundSyn == 0:
                    continue
            dif = abs(AlgorithmRPeaks[i] - DatasetRPeaks[j])
            diff.append(dif)
            j += 1
    return diff
def DetectingRPeaksAccuracy(start,end,plotting=False):
    classes = ['N', 'L', 'R', 'A', 'a', 'J', 'S', 'V', 'F', '!', 'e', 'j', 'E', '/', 'f', 'x', 'Q']
    filenames = [100,101,102,103,104,105,106,107,108,109,111,112,113,114,115,116,117,118,119,121,122,123,124,200,201,202,203,205,207,208,209,210,212,213,214,215,217,219,220,221,222,223,228,230,231,232,233,234]
    BeatsAllRecords = [2273,1865,2187,2084,2229,2572,2027,2137,1774,2532,2124,2539,1795,1879,1953,2412,1535,2288,1987,1863,2476,1518,1619,2601,2000,2136,2980,2656,2332,2955,3005,2650,2748,3251,2262,3363,2208,2287,2048,2427,2483,2605,2053,2256,1573,1780,3079,2753]
    totalError = 0
    results = []
    print('Testing Started')
    wrong = []
    shiftAVG = []
    AllAnnotations = dict()
    print(len(filenames))
    for i in range(20, len(filenames)):
        print('\n\nNow in record ' + str(filenames[i]))
        record = wfdb.rdrecord('mitdb/' + str(filenames[i]))
        annotation = wfdb.rdann('mitdb/' + str(filenames[i]), 'atr')
        for ann in annotation.symbol:
            if ann in AllAnnotations.keys():
                AllAnnotations[ann] += 1
            else:
                AllAnnotations[ann] = 1
        #annotation.symbol, annotation.sample = filterAnnotation(annotation)
        '''ann_samp=[qrs_inds]'''
        sig, fields = wfdb.rdsamp('mitdb/' + str(filenames[i]), channels=[0], sampfrom=start, sampto=end)

        NewSig = butter_bandpass_filter(sig, 0.9, 40, 300, 2)
        '''ann_samp=[qrs_inds]'''



        sig = normalized(sig)
        NewSig = normalized(NewSig)
        qrs_inds = processing.xqrs_detect(sig=sig[:, 0], fs=fields['fs'])
        if plotting:
            wfdb.plot_items(sig, title='Record ' + str(
                filenames[i]) + ' from MIT-BIH Arrhythmia Database\nSignal Before Filtering')
            wfdb.plot_items(NewSig, title='Record ' + str(
                filenames[i]) + ' from MIT-BIH Arrhythmia Database\nSignal After Filtering')


            wfdb.plot_items(NewSig,ann_samp=[qrs_inds], title='Record ' + str(
                filenames[i]) + ' from MIT-BIH Arrhythmia Database\nDetected R Peaks')
        #comparitor = processing.compare_annotations(annotation.sample[1:],qrs_inds,int(0.1 * fields['fs']),sig[:, 0])
        #comparitor.print_summary()
        #comparitor.plot()
            wfdb.plot_items(np.array(DynamicSegmentation(qrs_inds, NewSig)[0]), title='Record ' + str(
                filenames[i]) + ' from MIT-BIH Arrhythmia Database\nSegmented Beat')
        print('Algorithm Peaks ' + str(len(qrs_inds)))
        x = len(DynamicSegmentation(qrs_inds, sig))
        print('Algorithm R inds')
        print(list(qrs_inds))
        print('Data Set R inds')
        print(annotation.sample)
        print('Difference')
        diff = calcRPeaksDiff(qrs_inds, annotation.sample)
        print(diff)
        print(len(diff))
        avg = np.average(diff)
        shiftAVG.append(avg)
        print('AVG is ' + str(avg))
        results.append(x)
        totalError += abs(x - BeatsAllRecords[i])
        #wfdb.plot_items(sig, ann_samp=[qrs_inds], title='Record ' + str(filenames[i]) + ' from MIT-BIG Arrhythmia Database')
    print('Testing Finished')
    print('AVG ')
    print(shiftAVG)
    print('Total Shift Average '+str(np.average(shiftAVG)))
    print('Total Error ' + str(totalError))
    print(BeatsAllRecords)
    print(results)
    totalNumOfBeats = np.sum(BeatsAllRecords)
    right = totalNumOfBeats - totalError
    accuracy = float(right) / totalNumOfBeats * 100
    print('Accuracy of Detecting R Peaks ' + str(accuracy))
    return
DetectingRPeaksAccuracy(0,1200,True)