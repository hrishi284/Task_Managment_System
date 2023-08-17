import { Component } from '@angular/core';
import { Itask } from '../model/Itask';
import { MemberService } from '../service/member.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-task-list',
  templateUrl: './task-list.component.html',
  styleUrls: ['./task-list.component.css']
})
export class TaskListComponent {

  public tasks :Itask[] =[];

    constructor(private _memberservice :MemberService,private router : Router) {
        
    }
    ngOnInit() {
      
       this._memberservice.getTasks()
       .subscribe(data => this.tasks = data, error => console.error(error));

    }
    updatedel(id:string|undefined)
    {

      this.router.navigateByUrl('/UpdateTask', { state: {id} });
     
    }
    sorting()
    {
     return this.tasks.sort((a, b) => {
      return <any>new Date(a.dueDate) - <any>new Date(b.dueDate);
    });
    }

    sortingTitle()
    {
     return this.tasks.sort((a, b) => {
      return <any>new Date(a.title) - <any>new Date(b.title);
    });
    }

    res:string=''
    delete(id:string)
    {
      console.log(id);
      this._memberservice.deleteTask(id).subscribe(data => this.res=data, error => console.error(error))
      
      console.log(this.res);
    window.location.reload();
      
      
    }
}
