import { Component, OnDestroy, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Subscription } from 'rxjs';
import { ContentService } from '../../../../core/services/content.service';

@Component({
  selector: 'app-content-list',
  templateUrl: './content-list.component.html',
  styleUrls: ['./content-list.component.css'],
})
export class ContentListComponent implements OnInit, OnDestroy {
  contentType ;
  content = [];
  loadMoreCount;
  private contentSub: Subscription;

  constructor(private route: ActivatedRoute,
    private contentService: ContentService) {
    this.contentType = route.snapshot.data['type'];
  }

  ngOnInit(): void {
    this.loadMoreCount = 0;

    this.contentService.getTop10Content('',this.contentType, this.loadMoreCount);
    this.contentSub = this.contentService.getContentUpdateLstener().subscribe(content =>
      this.content = content);
  }

  loadMore(){
    this.contentService.getTop10Content('',this.contentType, this.loadMoreCount+1);
  }

  ngOnDestroy(): void {
    this.contentSub.unsubscribe()
  }
  
}
