-- NHIS database initialization script
CREATE DATABASE IF NOT EXISTS `nhis`;
USE `nhis`;

-- Users (basic auth table used by the app)
CREATE TABLE IF NOT EXISTS `users` (
  `id` INT AUTO_INCREMENT PRIMARY KEY,
  `full_name` VARCHAR(255) NOT NULL,
  `email` VARCHAR(255),
  `phone` VARCHAR(50),
  `role` VARCHAR(50),
  `password` VARCHAR(255)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- Members (registered NHIS members)
CREATE TABLE IF NOT EXISTS `members` (
  `id` INT AUTO_INCREMENT PRIMARY KEY,
  `patient_id` VARCHAR(100),
  `nhis_number` VARCHAR(100),
  `full_name` VARCHAR(255),
  `dob` DATE,
  `gender` VARCHAR(20),
  `nationality` VARCHAR(100),
  `membership_type` VARCHAR(50),
  `expiry_date` DATE,
  `phone` VARCHAR(50),
  `region` VARCHAR(100),
  `district` VARCHAR(100),
  `city` VARCHAR(100),
  `emergency_contact_name` VARCHAR(255),
  `emergency_contact_phone` VARCHAR(50),
  `relationship` VARCHAR(50)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- Providers
CREATE TABLE IF NOT EXISTS `providers` (
  `id` INT AUTO_INCREMENT PRIMARY KEY,
  `provider_id` VARCHAR(100),
  `name` VARCHAR(255),
  `type` VARCHAR(100),
  `region` VARCHAR(100),
  `district` VARCHAR(100),
  `phone` VARCHAR(50)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- Claims
CREATE TABLE IF NOT EXISTS `claims` (
  `id` INT AUTO_INCREMENT PRIMARY KEY,
  `claim_id` VARCHAR(100) NOT NULL,
  `provider_id` VARCHAR(100),
  `provider_name` VARCHAR(255),
  `nhis_number` VARCHAR(100),
  `patient_name` VARCHAR(255),
  `service_date` DATE,
  `amount` DECIMAL(10,2) DEFAULT NULL,
  `procedure_type` VARCHAR(255),
  `diagnosis_code` VARCHAR(100),
  `diagnosis_desc` TEXT,
  `ward_department` VARCHAR(255),
  `additional_notes` TEXT,
  `status` VARCHAR(50) DEFAULT 'Pending',
  `created_at` TIMESTAMP DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- Helpful index
CREATE INDEX IF NOT EXISTS idx_members_nhis ON members(nhis_number);
CREATE INDEX IF NOT EXISTS idx_claims_nhis ON claims(nhis_number);
