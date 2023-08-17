import { Component } from '@angular/core';
import { MemberService } from './service/member.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-root',
  
templateUrl :'app.component.html'
})
export class AppComponent {
  title = 'Task_Managment_frontend';
  
  constructor(private _memberservice :MemberService,private router : Router) {
        
  }
  

  open()
  {
    this.router.navigateByUrl('/login');
  }

 
}
