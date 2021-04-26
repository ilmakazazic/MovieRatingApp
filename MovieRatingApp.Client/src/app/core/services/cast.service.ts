import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from '../../../environments/environment';
import { CastDto } from '../../shared/model/cast.model';

@Injectable({
  providedIn: 'root'
})
export class CastService {

  private apiURL = environment.apiURL + "/Cast"

  constructor(private http : HttpClient) { }

  getCastByContentId(id: number){
    return this.http.get<CastDto[]>(`${this.apiURL}/Content/${id}`)
  }

}
