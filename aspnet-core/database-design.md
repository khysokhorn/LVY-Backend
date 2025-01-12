```mermaid
---
title: IVY Money Tracking
---
erDiagram
    Account {
        int id PK
        string name
        string icon
        decimal Income
        decimal Expend
        date createdDate
        int orderIndex
        string colorCode
    }
    User{
        int id PK
        string name 
    }
    AccountBalance{
        int userId PK, FK
        int accountID PK, FK
        decimal totalBalanceIncome
        decimal totalBalanceExpend
    }

    Category{
        int id PK
        string name
        string icon
        string color 
        decimal totalBalanceIncome
        decimal totalBalanceExpend
        int orderByIndex
    }

    UserCategory{
        int id PK
        int userID PK,FK
        int categoryID PK, FK
    }
    User || --o{ UserCategory : have
    Category || --o{ UserCategory : "Own By User"
    Account || -- o{ AccountBalance: "User Action"
    User || -- o{ AccountBalance: "Own"
