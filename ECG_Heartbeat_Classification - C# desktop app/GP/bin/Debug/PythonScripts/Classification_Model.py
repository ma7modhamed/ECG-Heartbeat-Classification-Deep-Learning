from sklearn.utils import shuffle
import numpy as np
from numpy import  newaxis
import pandas as pd

from sklearn.utils import shuffle
from sklearn.model_selection import train_test_split

#،Keras ......
#import keras
import  tensorflow as tf
from tensorflow import keras
from keras.models import Sequential
from keras.layers import Input , MaxPool1D , GlobalMaxPool1D , AvgPool1D , GlobalAvgPool1D , BatchNormalization
from keras.layers.core import Flatten, Dense, Dropout
from keras.layers.convolutional import Convolution2D, MaxPooling2D, ZeroPadding2D ,Convolution1D ,MaxPooling1D,ZeroPadding1D
from keras.optimizers import SGD
from keras import optimizers , activations
from keras import losses
from keras import metrics
from keras import models
from keras.models import Model , Sequential
from keras.layers import Conv1D , MaxPool1D , Dropout , Flatten , Dense ,\
 Input ,concatenate , GlobalAveragePooling1D , AveragePooling1D  , MaxPooling1D , BatchNormalization , Activation , GlobalAveragePooling2D

from keras.layers.convolutional import Convolution1D
from keras import optimizers , activations
from keras.optimizers import *
from keras.utils import plot_model


def CNN(nclass=16):
 inp = Input(shape=(300, 1))
 lay = Convolution1D(32, kernel_size=5, activation=activations.relu, padding="valid")(inp)
 lay = Convolution1D(32, kernel_size=5, activation=activations.relu, padding="valid")(lay)
 lay = AvgPool1D(pool_size=2)(lay)

 lay = Convolution1D(64, kernel_size=3, activation=activations.relu, padding="valid")(lay)
 lay = Convolution1D(64, kernel_size=3, activation=activations.relu, padding="valid")(lay)
 lay = Convolution1D(64, kernel_size=3, activation=activations.relu, padding="valid")(lay)
 lay = AvgPool1D(pool_size=2)(lay)
 lay = Dropout(rate=0.1)(lay)
 lay = BatchNormalization()(lay)

 lay = Convolution1D(64, kernel_size=3, activation=activations.relu, padding="valid")(lay)
 lay = Convolution1D(64, kernel_size=3, activation=activations.relu, padding="valid")(lay)
 lay = Convolution1D(64, kernel_size=3, activation=activations.relu, padding="valid")(lay)
 lay = AvgPool1D(pool_size=2)(lay)
 lay = Dropout(rate=0.1)(lay)
 lay = BatchNormalization()(lay)

 lay = Convolution1D(128, kernel_size=3, activation=activations.relu, padding="valid")(lay)
 lay = Convolution1D(128, kernel_size=3, activation=activations.relu, padding="valid")(lay)
 lay = Convolution1D(128, kernel_size=3, activation=activations.relu, padding="valid")(lay)
 lay = AvgPool1D(pool_size=2)(lay)
 lay = Dropout(rate=0.1)(lay)
 lay = BatchNormalization()(lay)

 lay = Convolution1D(256, kernel_size=3, activation=activations.relu, padding="valid")(lay)
 lay = Convolution1D(256, kernel_size=3, activation=activations.relu, padding="valid")(lay)
 lay = Convolution1D(256, kernel_size=3, activation=activations.relu, padding="valid")(lay)
 lay = GlobalMaxPool1D()(lay)
 lay = Dropout(rate=0.1)(lay)
 lay = BatchNormalization()(lay)

 dense_1 = Dense(64, activation=activations.relu)(lay)
 dense_1 = Dense(64, activation=activations.relu)(dense_1)
 dense_1 = Dense(nclass, activation=activations.softmax)(dense_1)

 model = models.Model(inputs=inp, outputs=dense_1)
 model.compile(optimizer=optimizers.Adam(lr=0.00001), loss=losses.categorical_crossentropy, metrics=['acc'])
 return model

def inception_module2(layer_in, f1, f2_in, f2_out, f3_in, f3_out, f4_out):
	# 1x1 conv
	conv1 = Conv1D(f1, 1, padding='same', activation='relu')(layer_in)
	# 3x3 conv
	conv3 = Conv1D(f2_in, 1, padding='same', activation='relu')(layer_in)
	conv3 = Conv1D(f2_out, 3, padding='same', activation='relu')(conv3)
	# 5x5 conv
	conv5 = Conv1D(f3_in, 1, padding='same', activation='relu')(layer_in)
	conv5 = Conv1D(f3_out, 5, padding='same', activation='relu')(conv5)
	# 3x3 max pooling
	pool = MaxPooling1D(1, strides=None, padding='same')(layer_in)
	pool = Conv1D(f4_out, 1, padding='same', activation='relu')(pool)
	# concatenate filters, assumes filters/channels last
	layer_out = concatenate([conv1, conv3, conv5, pool], axis=-1)
	return layer_out

def inception(nclass = 16):
    inp = Input (shape=(300,1))
    conv1 = Conv1D(32, 3, padding='same', activation='relu')(inp)
    conv2 = Conv1D(64, 3, padding='same', activation='relu')(conv1)
    Module= inception_module2(conv2 , 64, 96, 128, 16, 32, 32)
    Module2 = inception_module2(Module, 64, 96,128,   16, 32, 32) 
    batch = BatchNormalization() (Module2)
    Module3 = inception_module2(batch,  128, 128 , 192,32,96,64) 
    Module4 = inception_module2(Module3,  128, 128 ,192,32,96,64) 
    batch2 = BatchNormalization() (Module4)
    Module5 = inception_module2(batch2,  196 ,128,  256  ,64, 128,   96)
    Module6 = inception_module2(Module5, 196 ,128,  256  ,64, 128,   96)
    GAP = GlobalAveragePooling1D() (Module6) 
    layer = Dense(128 , activation='relu' ) (GAP)
    Dense_layer_ouput = Dense(16, activation='softmax') (layer)
    Dense_layer_ouput = Dense(nclass, activation='softmax') (layer)
    model = Model (inputs = inp , outputs = Dense_layer_ouput) 

    model.compile(loss='categorical_crossentropy', optimizer=optimizers.Adam(lr=0.0001), metrics=['accuracy'])

    #model .summary()
    return model
	
def Classify_Beats(beats  ,stage = 1 , Model = 'CNN' , subject = 0):
	beats = np.array (beats)
	if subject == 1:
		model = inception(5)
		model.load_weights('Weights\Subject\Inception\Subject-Oriented_inceptrain_50.1181895868928##81.16780113647772#Epoch 56.16780113647772#Epoch 56')
		Y_prediction = model.predict(beats)
		return  np.argmax(Y_prediction ,axis=1)
	if stage == 1 and Model == 'CNN' :
		model = CNN()
		model.load_weights('Weights\One_stage\CNN\CNN91.1751546375886 - 99.07885554780181#Epoch _ 159')
		Y_prediction = model.predict(beats)
		return  np.argmax(Y_prediction ,axis=1)

	elif stage == 1 and Model == 'Inception' :
		pass

	elif stage == 2 and Model == 'CNN' :
		pass

	elif stage == 2 and Model == 'Inception':
		pass

