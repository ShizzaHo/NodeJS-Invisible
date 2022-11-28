# NodeJS Invisible

## Использование

### Установка

Установка NodeJS Invisible делается всего в несколько шагов, просто загрузите файл Build.zip из вкладки Releases, и распакуйте содержимое на рабочий стол, вот и все! Все готово к работе!

### Настройка проекта

1. В корне **NodeJS Invisible** имеется **exe** файл и директория **NJSI_Data**, в этой директории и будет происходить вся найстройка проекта.
2. В директории **App** помещается ваще Node JS приложение
ВАЖНО: Все главные файлы проекта должны находиться именно в корне директории!
3. В директории **Integrated_NodeJS** можно распаковать NodeJS дистрибутив, чтобы у конечного пользователя была возможность использовать вашу программу с определнной Node JS версией, независимо от того, установлен ли на его компьютере NodeJS или нет.
4. В файле **config.ini** будет храниться конфигурация для запуска вашего проекта
    1. Раздел **Info**
        1. **ProgramName** - Название вашей программы, может быть абсолютно любым
    2. Раздел **NodeJS**
        1. **IntegratedNodeJS** - Определяет то, как будет запускаться ваша программа, из NodeJS установленного в системе пользователя, или из своего независимого дистрибутива лежащего в **Integrated_NodeJS** директории, принимает булевское значение (true/false)
        
    3. Раздел **Running**
        1. **StartCommand** - Стартовая команда, которая будет послана в NodeJS при запуске прилождения, например: npm start, node index
        2. **ShowConsole -** Показывать ли консоль при запуске приложения, принимает булевское значение (true/false)
        3. InstallDependencies - Определяет то, нужна ли установка зависимостей, принимает булевское значение (true/false)
        
    4. Раздел **Dependencies**
        1. **InstallCommand** - Команда которая будет выполнена если требуется установка зависимостей
        2. **ShowWindow -** Показывать ли окно с текстом при установке зависимостей, принимает булевское значение (true/false)
        3. **WindowText** - Текст который будет выведен в окне при установке зависимостей, для работы необходим включенный параметр **ShowWindow** 

## Требования для запуска проекта

- .NET Framework 4.0 и выше
- NodeJS (Опционально, зависит от конфигурации)
- Windows XP SP3 и выше

<hr>

# NodeJS Invisible

## Usage

### Installation

Installing NodeJS Invisible is done in just a few steps, just download the Build.zip file from the Releases tab, and unzip the contents to your desktop, that's it! You're all set to go!

### Setting up the project

1. In the root of **NodeJS Invisible** there is a **exe** file and a directory **NJSI_Data**, this is the directory where all the project configuration will take place.
2. In the directory **App** the Node JS application is placed
IMPORTANT: All the main files of the project must be in the root directory!
3. In the directory **Integrated_NodeJS** you can unpack the NodeJS distribution kit, so the end user will be able to use your program with the defined Node JS version, regardless of whether you have NodeJS installed on his computer or not.
4. The **config.ini** file will store the configuration for running your project
    1. Section **Info**
        1. **ProgramName** - The name of your program, can be absolutely any
    2. Section **NodeJS**
        1. **IntegratedNodeJS** - Determines how your program will be run from NodeJS installed in the system or from an independent distribution lying in the **Integrated_NodeJS** directory, takes boolean value (true/false)
        
    3. Section **Running**
        1. **StartCommand** - The start command which will be sent to NodeJS when the application starts, for example: npm start, node index
        2. **ShowConsole -** Whether or not to show the console at application startup, takes on a Boolean value (true/false)
        3) InstallDependencies - Determines whether or not you want to install dependencies, takes on a Boolean value (true/false).
        
    4. Section **Dependencies**.
        1. **InstallCommand** - The command to install dependencies.
        2. **ShowWindow -** Whether to show window with text when dependencies are installed, takes boolean value (true/false)
        3. **WindowText** - The text that will be displayed in the window when dependencies are installed, requires **ShowWindow** parameter to work 

## Requirements to start the project

- .NET Framework 4.0 and later
- NodeJS (Optional, depending on configuration)
- Windows XP SP3 and higher