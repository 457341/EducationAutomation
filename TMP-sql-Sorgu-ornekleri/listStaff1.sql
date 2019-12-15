 SELECT tStaff.ID,tStaff.name,UPPER(tStaff.surname),tStaff.startDate,tDepartments.name,tTasks.name,tEducationLevel.name
FROM tStaff,tStaff_tDepartments,tDepartments,tStaff_tTasks,tTasks,tStaff_tEducationLevel,tEducationLevel
WHERE   tStaff.ID = tStaff_tDepartments.ID and tStaff_tDepartments.departmentID = tDepartments.departmentID and
		tStaff.ID = tStaff_tTasks.ID and tStaff_tTasks.taskID = tTasks.taskID and
		tStaff.ID = tStaff_tEducationLevel.ID and tStaff_tEducationLevel.EducationLevelID = tEducationLevel.EducationLevelID
		and tStaff.name LIKE '%m%'



		/* tStaff.name LIKE '%m%'and tStaff.ID = 11111111111 and */