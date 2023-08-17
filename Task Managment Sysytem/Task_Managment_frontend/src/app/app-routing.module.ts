import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AddTaskComponent } from './add-task/add-task.component';
import { AppComponent } from './app.component';
import { TaskListComponent } from './task-list/task-list.component';
import { UpdateTasksComponent } from './update-tasks/update-tasks.component';
import { LoginComponent } from './login/login.component';
import { HomeComponent } from './home/home.component';

const routes: Routes = [
  { path: '', component: HomeComponent ,},
  { path: 'AllTask', component: TaskListComponent ,},
  { path: 'AddTask', component: AddTaskComponent ,},
  { path: 'login', component: LoginComponent ,},
  { path: 'UpdateTask', component: UpdateTasksComponent ,data:{id:''}},
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
