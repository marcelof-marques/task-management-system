import { Task } from './task';
import { User } from './user';

export class Project {
    id: number;
    name: string;
    description: string;
    tasks: Task[];
    user: User[];
}
