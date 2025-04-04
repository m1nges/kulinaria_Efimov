# kulinaria_WindowsForms-project
# Кулинарное приложение (WinForms + PostgreSQL)

Десктопное приложение, разработанное в учебных целях с использованием C# (WinForms) и базы данных PostgreSQL. Реализована система авторизации с защитой, регистрация с подтверждением по почте, управление пользователями и ролями, а также другой вспомогательный функционал.

---

## Основной функционал

- Авторизация с защитой от подбора пароля (капча при 2-х неудачных попытках)
- Редактирование профиля пользователя
- Панель администратора:
  - Управление пользователями
  - Назначение ролей
- Регистрация с подтверждением:
  - На указанный email отправляется логин и пароль (возможна доставка в папку "Спам")
- Хэширование паролей с использованием алгоритма SHA512
- Дополнительные функции доступны через пользовательский интерфейс

---

## Требования
- PostgreSQL 13 или выше
- Visual Studio

---

## Установка и запуск

### 1. Установка PostgreSQL

Скачать PostgreSQL можно с официального сайта:  
https://www.postgresql.org/download/

### 2. Создание и восстановление базы данных

1. Создайте базу данных с именем `kulinaria_Efimov`
2. Восстановите структуру и данные из дампа:

```bash
psql -U postgres -d kulinaria_Efimov -f Database/kulinaria_Efimov.sql
```

При необходимости можно использовать pgAdmin (Restore).
1. Зайти в pgAdmin
2. Создать бд kulinaria_Efimov
3. ПКМ->Backup-> выбрать файл восстановления БД

### 3. Настройка подключения

Подключение к базе данных настраивается в классе `DbConnection.cs`:

```csharp
public DbConnection()
{
    connectionStr = "Host=localhost;Port=5050;Username=postgres;Password=1;Database=kulinaria_Efimov";
}
```

При возникновении ошибки подключения проверьте:
- Доступность PostgreSQL
- Корректность логина и пароля
- Открытость указанного порта

---

## Тестовый пользователь

Для демонстрации функционала предусмотрен тестовый аккаунт:

- Логин: `GK`
- Пароль: `Gk12345@`
- Роль: администратор (доступ ко всем функциям)

Пароли пользователей хранятся в базе в виде SHA512-хэшей.

---

## Структура проекта

```
├── Forms/                 # Формы интерфейса (WinForms)
├── Images/                # Используемые изображения
├── Classes/               # Вспомогательная логика (Excel, почта, капча)
├── Model/                 # Модели данных
├── DbConnection.cs        # Класс подключения к базе данных
├── Database/
│   └── DbBackup.sql   # Дамп базы данных
│   └── backup.backup   # Дамп базы данных
├── Program.cs
├── kulinaria_Efimov.sln
└── README.md
```

---

## Примечания

- Подключение к базе реализовано с использованием библиотеки Npgsql.
- Относительные пути к изображениям позволяют запускать проект на любом устройстве без изменения путей.
- Для успешного запуска проекта необходимо наличие среды разработки с поддержкой WinForms, например, Visual Studio.


