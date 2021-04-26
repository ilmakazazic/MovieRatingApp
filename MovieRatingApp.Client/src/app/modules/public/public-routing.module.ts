import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ContentListComponent } from './components/content-list/content-list.component';
import { PublicComponent } from './public.component';

const routes: Routes = [
  {
    path: '',
    component: PublicComponent,
    children: [
      { path: 'tvshows', component: ContentListComponent, data: { type: 2 } },
      { path: 'movies', component: ContentListComponent, data: { type: 1 } },
      { path: '**', redirectTo: 'movies'},

    ],
  },


];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class PublicRoutingModule {}
