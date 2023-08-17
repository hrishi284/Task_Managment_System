import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Itask } from '../model/Itask';
import { Observable } from 'rxjs/internal/Observable';
import { FormGroup } from '@angular/forms';

@Injectable()
export class MemberService {


  constructor(private http :HttpClient) { }

  getTasks():Observable<Itask[]>
  {
    return this.http.get<Itask[]>('https://localhost:7114/api/task');
  }

  
  public saveTask(taskTemp:Itask): Observable<any> {
    
    return this.http.post<any>('https://localhost:7114/api/task', taskTemp);
  }

  public deleteTask(id:string): Observable<any> {
    
    return this.http.delete<any>('https://localhost:7114/api/task/'+id);
  }
  
  getByIdTasks(id:string):Observable<Itask>
  {
    return this.http.get<Itask>('https://localhost:7114/api/task/'+id);
  }

  updateTasks(id:string, t:Itask):Observable<any>
  {
    return this.http.put<any>('https://localhost:7114/api/task/'+id,t);
  }
}
