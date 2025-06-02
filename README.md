# 📝 TodoApp (.NET 9 + EF Core + SQLite)

A simple and robust web application built with **ASP.NET Core MVC**, **Entity Framework Core**, and **SQLite** to manage your daily tasks.  
Easily add, edit, complete, and delete todos with a clean UI!

---

## 🚀 Features

- **Add Todo**: Create new todo items with a title and completion status.
- **Edit Todo**: Update existing todos.
- **Delete Todo**: Remove todos you no longer need.
- **Mark as Completed**: Track which tasks are done.
- **Timestamps**: See when todos were created and last updated.
- **Validation**: Ensures all input data is valid before saving.
- **SQLite Database**: Lightweight and easy to use for development and small deployments.
- **Docker Support**: Run anywhere with Docker.

---

## 🗄️ Database Schema

| Field      | Type      | Description                |
|------------|-----------|----------------------------|
| Id         | GUID      | Primary Key                |
| Title      | STRING    | Todo Title (Required)      |
| Done       | BOOLEAN   | Completion Status          |
| CreatedAt  | DATETIME  | When the todo was created  |
| LastUpdate | DATETIME  | When the todo was updated  |

---

## 📦 Installation

1. **Clone the repo**
   ```sh
   git clone https://github.com/yourusername/TodoApp.git
   cd TodoApp/TodoApp
   ```

2. **Restore dependencies**
   ```sh
   dotnet restore
   ```

3. **Run database migrations**
   > Migrations are applied automatically at app startup.  
   > If you want to apply manually:
   ```sh
   dotnet ef database update
   ```

4. **Run the app**
   ```sh
   dotnet run
   ```
   The app runs on [http://localhost:5105](http://localhost:5105) (see [`Properties/launchSettings.json`](TodoApp/Properties/launchSettings.json)).

---

## 🐳 Docker

1. **Build the Docker image**
   ```sh
   docker build -t todoapp .
   ```

2. **Run the container**
   ```sh
   docker run -p 8080:8080 todoapp
   ```
   The app will be available at [http://localhost:8080](http://localhost:8080).

---

## 📚 Main Endpoints

- `GET /Todo` — List all todos
- `GET /Todo/Create` — Show create form
- `POST /Todo/Create` — Add a new todo
- `GET /Todo/Edit/{id}` — Edit a todo
- `POST /Todo/Edit/{id}` — Update a todo
- `GET /Todo/Delete/{id}` — Confirm delete
- `POST /Todo/Delete/{id}` — Delete a todo
- `GET /Todo/Details/{id}` — View todo details

---

## 🌐 Deployment

- Deployable anywhere with .NET 9 and SQLite support.
- For Docker, just use the provided [`Dockerfile`](TodoApp/Dockerfile).

---

## 🤝 Contributing

Pull requests are welcome! For major changes, please open an issue first to discuss what you would like to change.

---

## 📄 License

[MIT](LICENSE)

---

## ✨ Made with ❤️ by Saurabh
