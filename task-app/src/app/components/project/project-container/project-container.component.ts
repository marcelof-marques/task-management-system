import { Component, Input } from '@angular/core';
import { Project } from '../../../../models/project';

@Component({
    selector: 'app-project-container',
    templateUrl: './project-container.component.html',
    styleUrls: ['./project-container.component.css'],
})
export class ProjectContainerComponent {
    @Input() project: Project;
}
