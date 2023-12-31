﻿using DLL.EF.Models;
using DLL.Interfaces;
using DLL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL
{
    public class DataAccessFactory
    {
        public static IAuth AuthDataAccess()
        {
            return new UserRepo();
        }
        public static IRepo<User, int, bool, string> UserDataAccess()
        {
            return new UserRepo();
        }
        public static IRepo<Token, int, bool, string> TokenDataAccess()
        {
            return new TokenRepo();
        }

        public static IRepo<Post, int, bool, string> PostDataAccess()
        {
            return new PostRepo();
        }

        public static IRepo<Session, int, bool, string> SessionDataAccess()
        {
            return new SessionRepo();
        }
        public static IRepo<Job, int, bool, string> JobDataAccess()
        {
            return new JobRepo();
        }

        public static IJobApply<JobApplication,int,bool> JobApplyDataAccess()
        {
            return new JobApplicationRepo();
        }
        public static IComment<Comment, int, bool, string> CommentDataAccess()
        {
            return new CommentRepo();
        }

        public static IStatistical<User, int, bool, User, string> UserStaticalDataAccess()
        {
            return new UserRepo();
        }
        public static IStatistical<User, int, bool, User, string> ActiveUsersDataAccess()
        {
            return new UserRepo();
        }

        public static IStatistical<Session, int, bool, Session, string> AllActiveUserData()
        {
            return new SessionRepo();
        }
        public static IStatistical<Post, int, bool, Post, string> PostStatisticalDataAccess()
        {
            return new PostRepo();
        }
        public static IStatistical<Job, int, bool, Job, string> JobStatisticalDataAccess()
        {
            return new JobRepo();
        }
        public static ICV<CV, int, bool, string> CvDataAccess()
        {
            return new CVRepo();
        }

        public static ICV<AcademicQualification, int, bool, string> AcademicDataAccess()
        {
            return new AcademicRepo();
        }
        public static ICV<Award, int, bool, string> AwardDataAccess()
        {
            return new AwardRepo();
        }
        public static ICV<Experience, int, bool, string> ExperienceDataAccess()
        {
            return new ExperienceRepo();
        }
        public static ICV<Skill, int, bool, string> SkillDataAccess()
        {
            return new SkillRepo();
        }
        public static ICV<ThesisPaper, int, bool, string> ThesisDataAccess()
        {
            return new ThesisRepo();
        }
        public static IOTP<OTP,int, bool, User> OtpDataAccess()
        {
            return new OtpRepo();
        }
    }
}
