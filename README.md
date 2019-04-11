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

1) Install PowerShell 3.

2) Install [scoop](https://scoop.sh).
      
3) Once Scoop is installed then install Allure using Scoop command on PowerShell:

> PS> scoop install allure


4) Once Allure is install then in order to generate a report:

> allure serve PATH\allure-results