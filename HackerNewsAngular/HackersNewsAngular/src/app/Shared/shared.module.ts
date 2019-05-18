import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { SearchBoxComponent } from './search-box/search-box.component';
import { CommentComponent } from './comment/comment.component';
import { TitleComponent } from './title/title.component';
import { HttpClientModule } from '@angular/common/http';
import { LoadingIndicatorComponent } from './loading-indicator/loading-indicator.component';
import { CommentListComponent } from './comment-list/comment-list.component';



@NgModule({
  declarations: [
    SearchBoxComponent,
    CommentComponent,
    TitleComponent,
    LoadingIndicatorComponent,
    CommentListComponent
  ],
  imports: [
    CommonModule,
    HttpClientModule
  ],
  exports:[
    SearchBoxComponent,
    TitleComponent,
    LoadingIndicatorComponent,
    CommentListComponent
  ],
  providers:[]
})
export class SharedModule { }
