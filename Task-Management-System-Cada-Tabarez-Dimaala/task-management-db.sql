CREATE DATABASE task_management_db;
USE task_management_db;

CREATE TABLE users (
    user_id INT PRIMARY KEY AUTO_INCREMENT,
    username VARCHAR(50) NOT NULL UNIQUE,
    password VARCHAR(100) NOT NULL
); 

CREATE TABLE categories (
    category_id INT PRIMARY KEY AUTO_INCREMENT,
    category_name VARCHAR(100) NOT NULL,
    description VARCHAR(255)
); 

CREATE TABLE tasks (
    task_id INT PRIMARY KEY AUTO_INCREMENT,
    task_title VARCHAR(100) NOT NULL,
    description VARCHAR(255),
    due_date DATE,
    priority VARCHAR(20),
    status VARCHAR(20),
    assigned_to VARCHAR(100),
    category_id INT,
    FOREIGN KEY (category_id) REFERENCES categories (category_id)
); 

-- Insert Sample Data
INSERT INTO users (username, password) VALUES ('admin', 'admin123'); 

INSERT INTO categories (category_name, description) VALUES
('School', 'Academic related tasks'),
('Work', 'Office or job related tasks'),
('Personal', 'Personal reminders and activities'); 

INSERT INTO tasks (task_title, description, due_date, priority, status, assigned_to, category_id) VALUES
('Finish Documentation', 'Complete the project documentation', '2026-04-05', 'High', 'Pending', 'Member 1', 1),
('Design Dashboard', 'Create the main dashboard form', '2026-04-03', 'Medium', 'In Progress', 'Member 2', 2),
('Submit Final Project', 'Submit the final machine project', '2026-04-10', 'High', 'Pending', 'Both Members', 1); 