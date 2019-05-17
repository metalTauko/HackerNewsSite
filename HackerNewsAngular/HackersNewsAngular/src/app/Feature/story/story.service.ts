import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { Observer, Observable } from 'rxjs';
import { Story } from 'src/app/Models/Models';
import { HttpClient, HttpParams } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class StoryService {

  baseUrl = environment.baseurl + "story"
  
  constructor(private http: HttpClient) { }

  getItem(id:number): Observable<Story>{
    return this.http.get<Story>(this.baseUrl + "/" + id);
  }

  getTopStories(id:number): Observable<Array<Story>>{

    let params = new HttpParams();
    params = params.append("count", id.toString());

    return this.http.get<Array<Story>>(this.baseUrl + "/TopStories",{params : params});
  }
}
