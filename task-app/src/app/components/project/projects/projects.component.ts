import { Component, OnDestroy, ViewChild, AfterViewInit } from '@angular/core';
import { Observable, Subject, takeUntil } from 'rxjs';
import { ProjectService } from '../../../services/project-service.service';
import { MatPaginator } from '@angular/material/paginator';
import { MatSort, SortDirection } from '@angular/material/sort';
import { Project } from '../../../../models/project';
import { MatTableDataSource } from '@angular/material/table';

@Component({
    selector: 'div[app-projects]',
    templateUrl: './projects.component.html',
    styleUrls: ['./projects.component.css'],
})
export class ProjectsComponent implements OnDestroy, AfterViewInit {
    private destroy$ = new Subject();

    dataSource: MatTableDataSource<Project>;

    projects$: Observable<Project[]>;

    displayedColumns: string[] = ['Name', 'Description', 'Button'];

    isLoadingResults = true;
    isRateLimitReached = false;

    selectedProject: Project = null;

    @ViewChild(MatPaginator) paginator: MatPaginator;
    @ViewChild(MatSort) sort: MatSort;
    count: number;

    constructor(private projectService: ProjectService) {
        this.projects$ = this.projectService.getProjects();
        this.dataSource = new MatTableDataSource<Project>();

        this.getProjectData();
    }

    getProjectData() {
        this.projects$
            .pipe(takeUntil(this.destroy$))
            .subscribe((projects: Project[]) => {
                this.dataSource.data = projects;
            });
    }

    ngAfterViewInit(): void {
        this.dataSource.paginator = this.paginator;
        this.dataSource.sort = this.sort;
    }

    editProject(project: Project) {
        this.selectedProject = project;
    }

    ngOnDestroy(): void {
        this.destroy$.next(true);
        this.destroy$.complete();
    }
}
