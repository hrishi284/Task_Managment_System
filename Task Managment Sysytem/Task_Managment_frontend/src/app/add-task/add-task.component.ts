import { Component, OnInit } from '@angular/core';
import { MemberService } from '../service/member.service';
import { Itask } from '../model/Itask'; 

    

@Component({
  selector: 'app-add-task',
  templateUrl: './add-task.component.html',
  styleUrls: ['./add-task.component.css']
})
export class AddTaskComponent  implements OnInit {

  addTaskRequest:Itask   ={
    id:0 ,
    title: '', 
    description: '',
    dueDate: new Date ,
    isCompleted: false
  };
  

  
   constructor(private _memberservice :MemberService ) {
        
   }
  ngOnInit(): void {
    throw new Error('Method not implemented.');
  }
   res:string=''

  addTask() {  
   
  this._memberservice.saveTask(this.addTaskRequest).subscribe(data => this.res=data, error => console.error(error))
    console.log(this.addTaskRequest);
    console.log(this.res);

    
    };

}
