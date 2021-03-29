
![Unity Version](https://img.shields.io/badge/Unity-2018.1.0f2-orange.svg)
![Python Version](https://img.shields.io/badge/Python-3.8-blue.svg)
![NeuXus Version](https://img.shields.io/badge/NeuXus-1.0-purple.svg)

# poslux-rs
Resting-state EEG study between different position and illumination conditions.
## Run

 - Step 1: Launch [Brain Products Recorder](https://www.brainproducts.com/productdetails.php?id=21&tab=3) with RDA enabled.
 - Step 2: Launch **01_runExperiment.bat** 
 - Step 3: Launch [Lab Recorder](https://github.com/labstreaminglayer/App-LabRecorder)

## Protocol

![protocol](https://i.ibb.co/pzmd9gV/experiment.png)

## Prerequisites

### 1. Python
[Download for windows](https://www.python.org/downloads/windows/)

### 2.  pip
```
curl https://bootstrap.pypa.io/get-pip.py -o get-pip.py
```
```
py get-pip.py
```
[Installation instructions](https://pip.pypa.io/en/stable/installing/)

### 3. NeuXus

NeuXus requires Python 3.7+, verify your Python version with:
```
python --version
```
Install NeuXus with:
```
pip install neuxus
```
For more information, check [NeuXus repo](https://github.com/LaSEEB/NeuXus)





