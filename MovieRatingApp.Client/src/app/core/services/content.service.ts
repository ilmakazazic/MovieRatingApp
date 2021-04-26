import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Observable, Subject } from 'rxjs';
import { ContentDTO } from '../../shared/model/content.model';

@Injectable({
  providedIn: 'root'
})
export class ContentService {

  private apiURL = environment.apiURL + "/Content"
  private content: ContentDTO[] = [];
  private contentUpdated =  new Subject<ContentDTO[]>();
  private contentTypeId :number;
  constructor(private http : HttpClient ) { }

  getContentUpdateLstener() {
    return this.contentUpdated.asObservable();
  }

  getTop10Content(searchInput: string, contentTypeId : number, loadMoreCount : number){
    
    let tempTypeId = this.contentTypeId;
    this.contentTypeId = contentTypeId;

    if(tempTypeId != contentTypeId){
      this.content = [];
      this.contentUpdated.next([...this.content]);
    }

    const querryParams = `?ContentTypeId=${contentTypeId}&SearchInput=${searchInput}&LoadMoreCount=${loadMoreCount}`
    this.http.get<ContentDTO[]>(`${this.apiURL}${querryParams}`).subscribe((response) => {  
      if(loadMoreCount == 0)
        this.content = [];
      let tempArray = response;
      this.content.push(...tempArray)
      this.contentUpdated.next([...this.content])  
    });
  }

  addRatingPoints(id: number, points : number){
    const ratingPoints = {
      "ratingPoints" : points+1
    };
    console.log(`${this.apiURL}/${id}`, ratingPoints);
    return this.http.patch<ContentDTO>(`${this.apiURL}/${id}`, ratingPoints);
  }
}
