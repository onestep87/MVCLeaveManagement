# MVCLeaveManagement
Pet project for practicing .net core MVC

https://onestep87mvcpetproject.azurewebsites.net azure hosting 

<h2 >Here is quick overview of design choices </h2>
    <ul>
        <li><p>Code first approach, creating domain classes => then using EF migration to create and update database during development </p></li>
        <li><p>Using <strong>Repository Pattern</strong> to move out business logic out of the controllers</p></li>
        <li><p>Using <strong>Dependency Injection</strong> to have loosely coupled code and increase maintainability of application</p></li>
        <li><p>Implementing <strong>Authorization</strong> and <strong>Authentication </strong>using <strong>.NET Identity</strong></p></li>
        <li><p>Creating <strong>View Models</strong> for our domain classes to interact with user, mapping is done by <strong>AutoMapper </strong></p></li>
        <li><p>Source Control is being done by GitHub </p></li>
        <li><p>Azure DB and Azure App Service is used for hosting</p></li>
    </ul>
    <h2>Instructions for using App</h2>
    <h3>admin acc: test@gmail.com P@ssword1</h3>
    <h3>user acc: user@gmail.com P@ssword1</h3>
    <ul>
        <li><p>General idea is that this web app is used for creating, allocating, editing and requesting various Leave Types for employees of some company</p></li>
        <li><p>There is 2 types of users, Admin and Employee (you could create new employee user if you want)</p></li>
        <li><p>Admin has an overview of all employees in the System, he has an ability to manually change Employee allocationhe could create new Leave Types and edit existing, and Admin should approve or reject pending Employee request</p></li>
        <li><p>Employee can make a request for a new Leave, he could view status of his requests and if it's still pending, he could cancel it</p></li>
    </ul>


