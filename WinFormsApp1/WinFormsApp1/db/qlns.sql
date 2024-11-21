-- Tạo bảng employee
create database qlns

CREATE TABLE employee (
    employee_id INT PRIMARY KEY AUTO_INCREMENT,
    first_name VARCHAR(50) NOT NULL,
    last_name VARCHAR(50) NOT NULL,
    date_of_birth DATE,
    gender ENUM('Male', 'Female', 'Other'),
    phone VARCHAR(15),
    email VARCHAR(100),
    address VARCHAR(255),
    apartment_id INT,
    FOREIGN KEY (apartment_id) REFERENCES apartment(apartment_id)
);

-- Tạo bảng apartment
CREATE TABLE apartment (
    apartment_id INT PRIMARY KEY AUTO_INCREMENT,
    apartment_name VARCHAR(100),
    location VARCHAR(255)
);

-- Tạo bảng project
CREATE TABLE project (
    project_id INT PRIMARY KEY AUTO_INCREMENT,
    project_name VARCHAR(100),
    start_date DATE,
    end_date DATE,
    budget DECIMAL(15, 2)
);

-- Tạo bảng account
CREATE TABLE account (
    account_id INT PRIMARY KEY AUTO_INCREMENT,
    employee_id INT,
    username VARCHAR(50),
    password VARCHAR(255),
    role ENUM('Admin', 'Manager', 'Employee'),
    FOREIGN KEY (employee_id) REFERENCES employee(employee_id)
);

-- Tạo bảng salary
CREATE TABLE salary (
    salary_id INT PRIMARY KEY AUTO_INCREMENT,
    employee_id INT,
    amount DECIMAL(15, 2),
    payment_date DATE,
    FOREIGN KEY (employee_id) REFERENCES employee(employee_id)
);

-- Tạo bảng recruitment
CREATE TABLE recruitment (
    recruitment_id INT PRIMARY KEY AUTO_INCREMENT,
    position VARCHAR(100),
    number_of_positions INT,
    date_posted DATE,
    date_closed DATE
);

-- Tạo bảng notification
CREATE TABLE notification (
    notification_id INT PRIMARY KEY AUTO_INCREMENT,
    employee_id INT,
    message TEXT,
    date_sent DATE,
    FOREIGN KEY (employee_id) REFERENCES employee(employee_id)
);

-- Tạo bảng insurance
CREATE TABLE insurance (
    insurance_id INT PRIMARY KEY AUTO_INCREMENT,
    employee_id INT,
    insurance_type VARCHAR(100),
    start_date DATE,
    end_date DATE,
    FOREIGN KEY (employee_id) REFERENCES employee(employee_id)
);

-- Tạo bảng attendance
CREATE TABLE attendance (
    attendance_id INT PRIMARY KEY AUTO_INCREMENT,
    employee_id INT,
    attendance_date DATE,
    status ENUM('Present', 'Absent', 'Late', 'Leave'),
    FOREIGN KEY (employee_id) REFERENCES employee(employee_id)
);
