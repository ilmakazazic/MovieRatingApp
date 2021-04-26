import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';
import { ContentService } from '../../core/services/content.service';

@Component({
  selector: 'app-public',
  templateUrl: './public.component.html',
  styleUrls: ['./public.component.css'],
})
export class PublicComponent implements OnInit {
  search;
  contentType;

  constructor(
    public router: Router,
    private contentService: ContentService,
    private route: ActivatedRoute
  ) {
    this.contentType = route.snapshot.data['type'];
  }

  ngOnInit(): void {}

  updateResult() {
    if (this.search.length > 2) {
      if (this.router.url === '/movies') {
        this.contentType = 1;
      } else if (this.router.url === '/tvshows') {
        this.contentType = 2;
      }

      this.contentService.getTop10Content(this.search, this.contentType, 0);
    } else if (this.search == '') {
      this.contentService.getTop10Content(this.search, this.contentType, 0);
    }
  }
}
