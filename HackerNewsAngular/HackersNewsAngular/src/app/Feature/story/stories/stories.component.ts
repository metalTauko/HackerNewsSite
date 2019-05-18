import { Component, OnInit } from '@angular/core';
import { Story } from 'src/app/Models/Models';
import { StoryService } from '../story.service';

@Component({
  selector: 'app-stories',
  templateUrl: './stories.component.html',
  styleUrls: ['./stories.component.scss']
})
export class StoriesComponent implements OnInit {

  constructor(private storyService: StoryService) { }

  stories = new Array<Story>();

  display = new Array<Story>();
  
  loadingInd = false;
 
  ngOnInit() {
    this.loadingInd = true;
    this.storyService.getTopStories(20).subscribe(data=>{
      this.stories = data;
      this.display = data;
      this.loadingInd = false;
    })
  }

  search(event){
    if(event == ''){
      this.display = this.stories.slice();
    }
    this.display = this.stories.filter(f => f.title.toLowerCase().indexOf(event.toLowerCase()) > -1);
  }
}
