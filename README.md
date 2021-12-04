### Реализованная функциональность
* Работа с базами данных
* Реализована витрина
* Авторизация (в процессе)
### Особенности проекта
* Отображение оценок стартапов функциональными заказчиками
* простой пользовательский путь
* «заботливый» интерфейс
### Основной стек технологий
* C# ASP.net Core 5
* HTML/CSS
* MS SQLServer
* Git, Github
# Среда запуска
1.Развёртывание проекта осуществляется на Windows 10 в среде разработки Visual Studio 2019
2.Требуется установка Net Core 5
3.Требуется MSSQLServer
# Установка Net Core 5 и ASP.net
1. Зайти в Visual Studio Installer, кнопка изменить
2. Установить инструменты ASP.net, Net Core
## Установка БД
1. В VS 2019 зайти в средства, диспетчер пакетов NuGet, управление пакетами
2. Установить пакет Microsoft.EntityFrameworkCore.SqlServer
3. В файле `appsettings.json` пишем следующий код:
```
  "ConnectionStrings": {
    "VitrinaContext": "Server=(localdb)\\mssqllocaldb;Database=VitrinaContext-f1969c4a-1842-4bfa-a1fb-5502dac01d8a;Trusted_Connection=True;MultipleActiveResultSets=true"
  }
```
## Выполнение миграции
1. В VS 2019 зайти в средства, диспетчер пакетов NuGet, консоль диспетчера пакетов
2. Выполнить команды
```
Add-Migration
Update-Database
```
