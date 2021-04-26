import { Component, Input, OnInit } from '@angular/core';
import { ContentDTO } from '../../../../../shared/model/content.model';
import { CastService } from '../../../../../core/services/cast.service';

@Component({
  selector: 'app-content-card',
  templateUrl: './content-card.component.html',
  styleUrls: ['./content-card.component.css']
})
export class ContentCardComponent implements OnInit {

  @Input()
  contentGeneric;
  @Input()
  contentItem: ContentDTO;
  castList = []
  constructor(private castService: CastService) { }

  ngOnInit(): void {
    this.castService.getCastByContentId(this.contentItem.contentId).subscribe(cast =>
      this.castList = cast )
  }
}
