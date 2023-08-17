import { Component, OnInit } from '@angular/core';
import { Itask } from '../model/Itask';
import { MemberService } from '../service/member.service';
import { ActivatedRoute, Router } from '@angular/router';
import { MatSlideToggleChange } from '@angular/material/slide-toggle';


@Component({
  selector: 'app-update-tasks',
  templateUrl: './update-tasks.component.html',
  styleUrls: ['./update-tasks.component.css']
})
export class UpdateTasksComponent implements OnInit  {



  public task :Itask ={
    id:0 ,
    title: '', 
    description: '',
    dueDate: new Date ,
    isCompleted: false
  }
  id:string =''
isChecked: any;
res:string='';
  constructor(private router:Router, private activatedRoute:ActivatedRoute,private _memberservice :MemberService) {
    
}
onChange(value: MatSlideToggleChange) {
  this.task.isCompleted=value.checked
  console.log(value.checked);
  
  }

  ngOnInit(): void {
    this.id=history.state.id;
    console.log(this.id);
    this._memberservice.getByIdTasks(this.id)
        .subscribe(data =>{
           this.task.id = data.id
            this.task.title=data.title
            this.task.description=data.description
          this.task.dueDate= data.dueDate
          this.task.isCompleted=data.isCompleted
        }
          , error => console.error(error));

        console.log(this.task);
        
    
  }
  ress:string=''
  updateTasks()
  {
    console.log(this.task);
    
    this._memberservice.updateTasks(this.task.id.toString(),this.task).subscribe(data => this.res =data, error => console.error(error))
    this.router.navigateByUrl('/');
    
  }
  // }
  // ngOnInit(): void {
  //   this._memberservice.getByIdTasks(id)
  //      .subscribe(data => this.task = data, error => console.error(error));
  // }


  // delete(id:string)
  // {
  //   console.log(id);
  //   this._memberservice.deleteTask(id).subscribe(data => this.res=data, error => console.error(error))
  
  // window.location.reload();
    
    
  // }

}
