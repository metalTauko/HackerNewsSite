import { NgModule } from '@angular/core';
import { StoriesComponent } from './stories/stories.component';
import { CommonModule } from '@angular/common';
import { SharedModule } from 'src/app/Shared/shared.module';
import { StoryRoutingModule } from './story-routing.module';
import { StoryService } from './story.service';

@NgModule({
  declarations: [StoriesComponent],
  imports: [
    CommonModule,
    StoryRoutingModule,
    SharedModule
  ],
  providers:[
    StoryService
  ]
})
export class StoryModule { }
