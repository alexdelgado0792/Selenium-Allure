# Selenium-Allure
Selenium Webdriver + Allure report automation framework configuration (base project)

## Project Configuration

1) In allureConfig.json file change PATH and property change to copy always.

>{
  "allure": {
    "directory": "PATH\\allure-results"
  }
}

2) On Visual Studio Test Tab -> Test Settings -> Select config.runsettings of thos project.(Before running change Path)

## Allure Installation

Installation Refers to Section 2 of Allure documentation

https://docs.qameta.io/allure/#_installing_a_commandline

Windows platform installation

1) Install PowerShell 3 (or later) and .NET Framework 4.5 (or later).

2) Then on PowerShell run this command to install scoop 
(Refer to https://scoop.sh): 
            
iex (new-object net.webclient).downloadstring('https://get.scoop.sh')


> If you get an error you might need to change the execution policy (i.e. enable PowerShell):
Set-ExecutionPolicy RemoteSigned -scope CurrentUser

3) Once Scoop is installed then install Allure using Scoop command on PowerShell:

> scoop install allure


4) Once Allure is install then in order to generate a report in temporary folder from the data found (test results) in the provided path use next command:

> C:\Users\UserName>allure serve PATH

Example (Windows Command Prompt or PowerShell):

> allure serve PATH\allure-results