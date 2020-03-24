export interface CoursesList {
  coursesList: Courses[];
}

export interface Courses {
  id: number;
  courseName: string;
  description: string;
  duration: number;
  startDate: Date;
  coverUrl: string;
}
