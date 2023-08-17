# Task_Managment_System
**Assignment: Building a Task Management Web Application** 

 

**Description:** 

 

As a fresher developer, your assignment is to create a simple Task Management Web Application using the .NET framework for the backend and Angular for the frontend. This application will allow users to manage their tasks by adding, updating, and deleting tasks. 

 

**Requirements:** 

 

**Backend (.NET)** 

 

1. Create a .NET Web API project to serve as the backend of the application. 

2. Implement CRUD (Create, Read, Update, Delete) operations for tasks. 

3. Use Entity Framework or any other ORM for data management. 

4. Design API endpoints for managing tasks (e.g., GET /api/tasks, POST /api/tasks, PUT /api/tasks/{id}, DELETE /api/tasks/{id}). 

5. Implement proper validation for task data (e.g., task name, description, due date). 

 

**Frontend (Angular)** 

 

1. Create an Angular project to serve as the frontend of the application. 

2. Implement a task listing page where users can see a list of their tasks. 

3. Create a form to add new tasks with fields like task name, description, and due date. 

4. Implement the ability to update task details and mark tasks as completed. 

5. Provide a way to delete tasks from the list. 

6. Implement basic validation on the frontend to ensure proper task data is entered. 

 

**Additional Tasks (Optional, for Bonus Points):** 

 

 

1. Implement user authentication and authorization to ensure that only authenticated users can access and manage tasks. 

2. Add sorting and filtering options for the task list (e.g., sort by due date, filter by completion status). 

3. Improve the UI/UX with responsive design and user-friendly interactions. 

4. Implement task priorities (e.g., high, medium, low) and allow users to set them. 

5. Add the ability to set reminders for tasks, sending notifications when tasks are due. 

 

Development Approach: 

**Task Management Web Application** 

 

**Backend (.NET)** 

 

1. **Setup:** 

   - Create a new ASP.NET Web API project. 

   - Configure Entity Framework for database access. 

 

2. **Model:** 

   - Create a `Task` model with properties like `Id`, `Title`, `Description`, `DueDate`, and `IsCompleted`. 

 

3. **Controllers:** 

   - Create a `TasksController` with actions for CRUD operations. 

   - Implement GET, POST, PUT, and DELETE endpoints for tasks. 

 

4. **Data Access:** 

   - Use ADO .Net  to interact with the database. 

   - Implement data validation for task properties. 

 

5. **Authentication (Optional):** 

   - Implement user authentication using JWT. 

   - Secure the API endpoints to ensure only authenticated users can perform actions. 

 

**Frontend (Angular)** 

 

1. **Setup:** 

   - Create a new Angular project using Angular CLI. 

 

2. **Components:** 

   - Create a component for the task list page. 

   - Create a component for adding and editing tasks. 

 

3. **Services:** 

   - Create a service to interact with the backend API (e.g., `TaskService`). 

   - Implement methods for fetching tasks, creating tasks, updating tasks, and deleting tasks. 

 

4. **Task List Page:** 

   - Display a list of tasks, showing title, due date, and completion status. 

   - Implement a button to mark tasks as completed. 

   - Implement a button to delete tasks. 

 

5. **Task Form Component:** 

   - Create a form to add and edit tasks. 

   - Implement form validation for task properties. 

   - Use Angular Reactive Forms to manage form data. 

 

6. **Routing:** 

   - Set up routing to navigate between the task list and task form components. 

 

7. **Styling:** 

   - Apply CSS or a UI library (e.g., Bootstrap) to style the application. 

 

**Testing and Deployment** 

 

1. **Testing:** 

   - Test the application for functionality, including CRUD operations and task manipulation. 

   - Test user authentication and authorization if implemented. 

 

**Additional Features (Optional):** 

 

1. **Sorting and Filtering:** 

   - Implement sorting tasks by due date or completion status. 

   - Add a filter to show only completed or uncompleted tasks. 

 

2. **User Accounts and Data Isolation:** 

   - Implement user authentication to allow users to have their own set of tasks. 

   - Associate tasks with specific users. 

 

4. **Reminders:** 

   - Implement a feature to set reminders for tasks and notify users when tasks are due. 

 

Remember, this example provides a high-level overview of the steps and components involved in building a Task Management Web Application. You can customize and expand on each part according to your skills and requirements.  
