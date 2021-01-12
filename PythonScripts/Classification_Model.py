from sklearn.utils import shuffle
import numpy as np
from numpy import  newaxis
import pandas as pd

from sklearn.utils import shuffle
from sklearn.model_selection import train_test_split

#،Keras ......
#import keras
import tensorflow as tf
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



def Classify_Beats(beats  ,stage = 1 , Model = 'CNN' ):
 beats = np.array (beats)

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

