
from ECG_Preprocessing import *


import os

def ClusteringList(lis):
    distinct = list(set(lis))
    dic = {}
    for i in distinct:
        dic[i] = list.count(lis,i)
    return dic


def filterAnnotation(annotation):
    classes = ['N', 'L', 'R', 'A', 'a', 'J', 'S', 'V', 'F', '!', 'e', 'j', 'E', '/', 'f', 'x', 'Q']
    annotations = []
    RPeaksInds = []
    for ann in range(len(annotation.symbol)):
        if annotation.symbol[ann] in classes:
            annotations.append(annotation.symbol[ann])
            RPeaksInds.append(annotation.sample[ann])
    return annotations,RPeaksInds
def GetAllAnnotations(filenames):
    AllAnnotations = dict()
    print(len(filenames),'Record')
    for i in range(0, len(filenames)):

        annotation = wfdb.rdann('mitdb/' + str(filenames[i]), 'atr')
        c = 0
        for ann in annotation.symbol:
            if c == 0 or c == len(annotation.symbol)-1:
                c+=1
                continue
            c+=1
            if ann in AllAnnotations.keys():
                AllAnnotations[ann] += 1
            else:
                AllAnnotations[ann] = 1
    return AllAnnotations



#writing files functions
def AppendBeatsOfSignalToFile(beats,filePath):
    f = open(filePath,"a")
    for i in range(len(beats)):
        for j in range(len(beats[i])):
            f.write(str(beats[i][j][0])+'|')
        f.write('\n')
    f.close()
    return
def WriteAnnotationSymbolToFile(annotationSymbol,filepath):
    f = open(filepath,"a")
    for i in range(1,len(annotationSymbol)-1):
        f.write(str(annotationSymbol[i])+'\n')
    f.close()

    return
def PrepareFiles(filenames , directory):
    print('writing two files has been started')
    for i in range(0,len(filenames)):
        print('Now in record '+str(filenames[i]))
        annotation = wfdb.rdann('mitdb/' + str(filenames[i]), 'atr')
        annotation.symbol, annotation.sample = filterAnnotation(annotation)
        sig, fields = wfdb.rdsamp('mitdb/' + str(filenames[i]), channels=[0], sampfrom=0, sampto=None)
        beats = PreProcessing(sig,fields['fs'],annotation.sample)

        AppendBeatsOfSignalToFile(beats,directory+'mitdbAllBeats.txt')
        WriteAnnotationSymbolToFile(annotation.symbol,directory+'mitdbAllAnnotationsSymbols.txt')
    print('done')

def ClusteringBeatsInFiles(BeatsFilePath,AnnotationFilePath , directory):
    classes = ['N', 'L', 'R', 'A', 'a', 'J', 'S', 'V', 'F', '!', 'e', 'j', 'E', '/', 'f', 'x', 'Q']
    bf = open(BeatsFilePath,"r")
    annf = open(AnnotationFilePath,"r")
    beats = bf.readlines()
    annotations = annf.readlines()
    print(len(beats))
    print(len(annotations))
    b = {}
    files = {'N':'Normal', 'L':'Left_bundle_branch_block', 'R':'Right_bundle_branch_block', 'A':'Atrial_premature',
         'a':'Aberrated_atrial_premature','J':'Nodal(junctional)premature', 'S':'Supraventricular_premature',
         'V':'Premature_ventricular_contraction', 'F':'Fusion_of_ventricular_and_normal',
         '!':'Ventricular_flutter_wave', 'e':'Atrial_escape', 'j':'Nodal(junctional)escape','E':'Ventricular_escape',
         '/':'Paced', 'f':'Fusion_of_paced_and_normal', 'x':'Non-conducted_P-wave', 'Q':'Unclassifiable'}
    for i in classes:
        b[i] = []
    for i in range(len(beats)):
        b[annotations[i].split('\n')[0]].append(beats[i])
    for ann , bts in b.items():
        f = open(directory+files[ann]+'.txt' , "w")
        f.writelines(bts)
        f.close()



def ReadClassData(path,ZeroBased_classNumber,NumOfClasses):
    Data = open(path, "r").readlines()
    X = []
    for i in Data:
        row = i.split('|')
        row.remove('\n')
        row = list(map(float, row))
        X.append(row)
    X = np.array(X)
    Yi = np.zeros(NumOfClasses)
    Yi[ZeroBased_classNumber] = 1
    Y = np.vstack([Yi]*X.shape[0])
    return X,Y

from sklearn.model_selection import train_test_split
def PrepareTrainingTestingData(directory):
    files = {'N': 'Normal', 'L': 'Left_bundle_branch_block', 'R': 'Right_bundle_branch_block', 'A': 'Atrial_premature',
             'a': 'Aberrated_atrial_premature', 'J': 'Nodal(junctional)premature', 'S': 'Supraventricular_premature',
             'V': 'Premature_ventricular_contraction', 'F': 'Fusion_of_ventricular_and_normal',
             '!': 'Ventricular_flutter_wave', 'e': 'Atrial_escape', 'j': 'Nodal(junctional)escape',
             'E': 'Ventricular_escape',
             '/': 'Paced', 'f': 'Fusion_of_paced_and_normal', 'x': 'Non-conducted_P-wave', 'Q': 'Unclassifiable'}
    path = directory + files['S'] + '.txt'
    XN , YN = ReadClassData(path,3,17)
    train_test_split(XN,YN,test_size=0.4)


#PrepareTrainingTestingData('MITBIH - PreProcessed data/')
#PrepareFiles()
#ClusteringBeatsInFiles('mitdbAllBeats.txt','mitdbAllAnnotationsSymbols.txt')
filenames = [100, 101, 102, 103, 104, 105, 106, 107, 108, 109, 111, 112, 113, 114, 115, 116, 117, 118, 119, 121,
                 122, 123, 124, 200, 201, 202, 203, 205, 207, 208, 209, 210, 212, 213, 214, 215, 217, 219, 220, 221,
                 222, 223, 228, 230, 231, 232, 233, 234]
train_records = [101,106,108,109,112,114,115,116,118,119,122,124,201,203,205,207,208,209,215,220,223,230]
train2_records = [104,101,106,108,109,112,114,115,116,118,119,122,124,201,203,205,207,208,209,215,220,223,230]

test_records = [100,103,105,111,113,117,121,123,200,202,210,212,213,214,219,221,222,228,231,232,233,234]
classes = ['N', 'L', 'R', 'A', 'a', 'J', 'S', 'V', 'F', '!', 'e', 'j', 'E', '/', 'f', 'x', 'Q']
def SelectFromDict(keys,dictionary):
    new_dictionary = {}
    for key in keys:
        if key in dictionary.keys():
            new_dictionary[key] = dictionary[key]
        else:
            new_dictionary[key] = 0
    return new_dictionary

print('Train Records')
print(SelectFromDict(classes, GetAllAnnotations(train_records)))
print('New Train Records')
print(SelectFromDict(classes, GetAllAnnotations(train2_records)))
print('Test Records')
print(SelectFromDict(classes, GetAllAnnotations(test_records)))

subject_dir = 'Subject-Oriented/'
subject_train_dir = subject_dir + 'Train/'
subject_test_dir = subject_dir + 'Test/'
#PrepareFiles(train_records,subject_train_dir)
#PrepareFiles(test_records,subject_test_dir)

#ClusteringBeatsInFiles(subject_train_dir+'mitdbAllBeats.txt' , subject_train_dir+'mitdbAllAnnotationsSymbols.txt',subject_train_dir)
#ClusteringBeatsInFiles(subject_test_dir+'mitdbAllBeats.txt' , subject_test_dir+'mitdbAllAnnotationsSymbols.txt',subject_test_dir)
def WriteAllFiles(directory,classes_dir, records):
    if not os.path.exists(directory):
        os.makedirs(directory)
    if not os.path.exists(classes_dir):
        os.makedirs(classes_dir)

    PrepareFiles(records,directory)
    ClusteringBeatsInFiles(directory+'mitdbAllBeats.txt' , directory+'mitdbAllAnnotationsSymbols.txt',classes_dir)

WriteAllFiles('New Train Subject/','New Subject-Oriented/Train/',train2_records)