select [dbo].[studentTermRegestrations].studentId from
([dbo].[subjects] join [dbo].[termsSubjects] on 
[dbo].[subjects].Id = [dbo].[termsSubjects].SubjectId) join
[dbo].[studentTermRegestrations] on [dbo].[studentTermRegestrations].termId = [dbo].[termsSubjects].termId
where [dbo].[subjects].Id = 2;

