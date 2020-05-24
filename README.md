## CodeReady Container: OpenShift 4 on your laptop

This is a companion app for CodeReady Containers, it works only on Windows
For the CRC project head over to: https://github.com/code-ready/crc

[![Build status](https://ci.appveyor.com/api/projects/status/11upwe64sapyhoq7/branch/master?retina=true)](https://ci.appveyor.com/project/anjannath/tray-windows/branch/master)

### How to use

1. You need the latest CRC binary first. Download it from https://github.com/code-ready/crc/releases
2. Download the zip `tray-windows.zip` from the releases
3. run `crc daemon`
4. Extract the contents of `tray-windows.zip` and double click on **tray-windows**
5. _Pull Secret_ and _Bundle_ must be configured with `crc config set pull-secret-file` and `crc config set bundle`

### Screenshots

<img src="https://i.imgur.com/wDXWrXH.png" alt="shot2" width="270" height="230"/>

### Steps to build

**Note: You need Visual Studio to build**

1. Clone this repository `git clone https://github.com/code-ready/tray-windows.git`.
2. Import the solution `tray-windows.sln` to Visual Studio .
3. Build from the Build menu on in Visual Studio.
