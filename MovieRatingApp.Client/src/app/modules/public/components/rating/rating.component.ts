import { Component, Input, OnInit } from '@angular/core';
import { PointsDto } from '../../../../shared/model/points.model';
import { ContentService } from '../../../../core/services/content.service';

@Component({
  selector: 'app-rating',
  templateUrl: './rating.component.html',
  styleUrls: ['./rating.component.css']
})
export class RatingComponent implements OnInit {
  @Input()
  maxRating = 5;
  
  @Input()
  SelectedRatingPoints = 0;
  maxRatingArray = [];
  points : PointsDto; 

  @Input()
  contentId;
  @Input()
  contentAverageRating;

  constructor(private contentService : ContentService) {}

  ngOnInit(): void {
    this.maxRatingArray = Array(this.maxRating).fill(0);
  }

  handleMouseEnter(index: number) {
    this.SelectedRatingPoints = index +1;
  }

  handleMouseLeave()
  {
    this.SelectedRatingPoints = 0;
  }

  addRatingPoints(index){
    this.contentService.addRatingPoints(this.contentId, index + 1).subscribe();
    alert("Thank you for rating!");
    location.reload();
  }
}
