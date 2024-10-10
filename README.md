# Pratik - Code First Relation

## Overview

This project demonstrates the implementation of the Code First approach using Entity Framework Core to create a database and relationships between tables.

## Database Structure

### Tables

1. **User Table**
   - **Id**: `int`, primary key, auto-incremented.
   - **Username**: `string`, user's username.
   - **Email**: `string`, user's email address.

2. **Post Table**
   - **Id**: `int`, primary key, auto-incremented.
   - **Title**: `string`, title of the post.
   - **Content**: `string`, content of the post.
   - **UserId**: `int`, foreign key representing the author of the post (user's ID).

### Relationships
- A user can have multiple posts, but each post belongs to a single user.

## DbContext

- The context class is named **PatikaSecondDbContext**.
- The database name is **PatikaCodeFirstDb2**.
- The database contains the tables **Users** and **Posts**.

## Setup Instructions

1. Ensure you have **Entity Framework Core** installed in your project.
2. Configure the database connection string in the `appsettings.json` file.
3. Create the database and tables using migrations.
