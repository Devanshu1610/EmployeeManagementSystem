# EmployeeManagement

**HTTPGet request**
GetALL employee   : https://localhost:44311/api/employee
Getemployeedetail :https://localhost:44311/api/employee/<EmployeeId> e.g, https://localhost:44311/api/employee/3
GetHikePercentage :https://localhost:44311/api/employee/<EmployeeId>/HikePercentage e.g, https://localhost:44311/api/employee/1005/HikePercentage
GetBonus          :https://localhost:44311/api/employee/<EmployeeId>/Bonus    e.g. https://localhost:44311/api/employee/1005/Bonus
  
  **HTTPPost request**
  
  Add Employee : https://localhost:44311/api/employee 
  Accept: JSON
  RequestBody = {
        "name": "Bernardo",
        "department": "Admin",
        "workLocation": "Bangalore",
        "technologyStack": null,
        "dateOfJoining": "2013-03-12T00:00:00",
        "rating": 7,
        "ctc": 2100000,
        "baseSalary": 100000,
        "managerName": null} 
  
  Add Bulk Employee : https://localhost:44311/api/employeeCollection
  Accept : JSON
  RequestBody =
  [ {
       
        "name": "Bethany",
        "department": "IT",
        "workLocation": "Hyderabad",
        "technologyStack": ".Net",
        "dateOfJoining": "2013-06-10T00:00:00",
        "rating": 6,
        "ctc": 2400000,
        "baseSalary": 100000,
        "managerName": "Estella"
    },
    {

        "name": "Reid",
        "department": "IT",
        "workLocation": "Delhi",
        "technologyStack": "Fullstack",
        "dateOfJoining": "2017-03-12T00:00:00",
        "rating": 8,
        "ctc": 1800000,
        "baseSalary": 100000,
        "managerName": "Devanshu"
    }
       ]
  
  **HTTPDelete**
    Delete an employee  :https://localhost:44311/api/employee/<EmployeeId> e.g.https://localhost:44311/api/employee/8 
  
  **HTTPPut**
  Update an employee : https://localhost:44311/api/employee/8
  Accept: JSON
  Request Body :
  {
    "name": "Devanshu Srivastava",
    "department": "HR",
    "workLocation": "Delhi",
    "technologyStack": null,
    "dateOfJoining": "2011-03-12T00:00:00",
    "rating": 0,
    "ctc": 2100000,
    "baseSalary": 100000,
    "managerName": null
}
  
 **DataBase setup**
1)  Create a Database Name EmployeeDB
2)  Run CreateEmployeeTable script to create Employee table
3)  Run InsertScript to push some initial data in database  
 4) Update connection string key "EmployeeDBContextConnectionString" in appsettings.json
  
  
  
  
