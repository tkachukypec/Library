# День с-1. 

Знакомство с рабочими местами

## Подготовка рабочего места.

Пожалуйста, отредактируйте файл C:\Windows\System32\drivers\etc\hosts
добавьте в конец файла строку

```
172.16.1.1 wsr
```

## Проверка рабочего места.

Не забудьте проверить весь необходимый софт для выполнения всех модулей.

## Сетевой диск (музыка)

Подключение в проводнике

```
\\wsr\public
```

Если не подключается, то надо сделать следующее:

1. Открыть редактор локальной групповой политики (выполнить **gpedit.msc**)
2. Перейти **Конфигурация компьютера/Административные шаблоны/Сеть/Рабочая станция lanman**
3. Открыть настройку **Включить небезопасные гостевые входы** и выбрать **включить**

После этого в проводнике должен заработать доступ к сетевому диску.

## для импорта из эксель

Чтобы заработал импорт из Excel надо скачать из этого репозитория accessdatabaseengine.exe
и запусить с ключем /quiet


```
accessdatabaseengine.exe /quiet
```

## для продления пробного периода ms Office

Выполнить с правами администратора:

```
C:\Program Files\Microsoft Office\Office16\OSPPREARM.EXE
```