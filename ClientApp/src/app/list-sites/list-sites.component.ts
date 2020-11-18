import { Component, OnInit, Inject } from '@angular/core';
import { SiteService } from '../Services/site.service';
import { Gallery } from '../Models/Gallery';
import { Site } from '../Models/Site';
import {Calificacion} from '../Models/Calificacion';
import { from } from 'rxjs';

@Component({
  selector: 'app-list-sites',
  templateUrl: './list-sites.component.html',
  styleUrls: ['./list-sites.component.css']
})

export class ListSitesComponent implements OnInit {
  sites : Site[];
  Calificacion : Calificacion;
  constructor(
    @Inject('BASE_URL') public baseUrl: string,
    private galleryService : SiteService
  ) { }

  ngOnInit() {
    this.get();

  }

  get(){
    this.galleryService.get().subscribe(
      (data) => {
        this.sites = data;
        console.log(data);
      }
    ), error => {
      console.error(error)
    };
  }
}
