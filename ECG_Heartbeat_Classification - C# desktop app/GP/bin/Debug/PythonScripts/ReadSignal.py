import sys
import ECG_Preprocessing as ECG

#sig = ECG.Read_Signal( signalPath='mit-bih-arrhythmia-database-1.0.0/100')  #will Remove This Line

signal_path = sys.argv[1]
print(signal_path)
sig = ECG.Read_Signal( signalPath=signal_path)
sig = ECG.normalized(sig)
# @ Write Signal TXT @ #
ECG.Write_txt(file_name='Signal.txt' , Data=sig)

print('Finished Successfuly')

