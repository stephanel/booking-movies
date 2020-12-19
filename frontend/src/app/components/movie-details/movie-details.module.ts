import { CommonModule } from '@angular/common';
import { MatButtonModule } from '@angular/material/button';
import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { MovieDetailsComponent } from 'src/app/components/movie-details/movie-details.component';

@NgModule({
  imports: [
    // angular modules
    CommonModule,
    RouterModule,

    // material modules
    MatButtonModule,
  ],
  declarations: [MovieDetailsComponent],
  exports: [RouterModule],
})
export class MovieDetailsModule {}
