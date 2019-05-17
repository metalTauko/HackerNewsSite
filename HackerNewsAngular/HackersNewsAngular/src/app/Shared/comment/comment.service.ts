import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Comment } from '../../Models/Models';

@Injectable({
  providedIn: 'root'
})
export class CommentService {


  baseUrl = environment.baseurl + "comment"
  
  constructor(private http: HttpClient) { }

  getItem(id:number): Observable<Comment>{
    return this.http.get<Comment>(this.baseUrl + "/" + id);
  }
}
