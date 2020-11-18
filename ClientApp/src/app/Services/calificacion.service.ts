import { Inject, Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Gallery } from '../Models/Gallery';
import { Observable } from 'rxjs';
import { Calificacion } from '../Models/Calificacion';

@Injectable({
  providedIn: 'root'
})
export class CalificacionService {

  constructor(private http: HttpClient,
    @Inject('BASE_URL') private baseUrl: string) {



   }

   addCalificacion(Calificacion):Observable <Calificacion>{

    return this.http.post<Calificacion>(`${this.baseUrl}api/Calificacion`,Calificacion);
  }

}
