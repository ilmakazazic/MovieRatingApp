import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { PublicRoutingModule } from './public-routing.module';
import { ContentListComponent } from './components/content-list/content-list.component';
import { ContentCardComponent } from './components/content-list/content-card/content-card.component';
import { RatingComponent } from './components/rating/rating.component';
import { MatIconModule } from '@angular/material/icon';
import { MatTabsModule } from '@angular/material/tabs'
import { MatButtonModule } from '@angular/material/button';
import { MatInputModule } from '@angular/material/input';
import { PublicComponent } from './public.component';
import { FormsModule } from '@angular/forms';


@NgModule({
  declarations: [
    ContentListComponent,
    ContentCardComponent,
    RatingComponent,
    PublicComponent
  ],
  imports: [
    CommonModule,
    PublicRoutingModule,
    MatIconModule,
    MatTabsModule,
    MatButtonModule,
    MatInputModule,
    FormsModule
  ]
})
export class PublicModule { }
