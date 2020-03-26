using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace University.Migrations.EntityConfigurations
{
    public class CoursesConfiguration : IEntityTypeConfiguration<CourseEntity>
    {
        private static DateTime currentDate;
        public CoursesConfiguration()
        {
            currentDate = DateTime.UtcNow;
        }
        public void Configure(EntityTypeBuilder<CourseEntity> builder)
        {
            int courseId = 0;
            builder.HasData(
            new CourseEntity
            {
                ID = ++courseId,
                CourseName = "Geometry and Trygonometry",
                Description = "Yet bed any for travelling assistance indulgence unpleasing. Not thoughts all exercise blessing. Indulgence way everything joy alteration boisterous the attachment. Party we years to order allow asked of. We so opinion friends me message as delight. Whole front do of plate heard oh ought. His defective nor convinced residence own. Connection has put impossible own apartments boisterous." +
                "At jointure ladyship an insisted so humanity he. Friendly bachelor entrance to on by." +
                "Its had resolving otherwise she contented therefore.Afford relied warmth out sir hearts sister use garden.Men day warmth formed admire former simple.Humanity declared vicinity continue supplied no an.He hastened am no property exercise of.Dissimilar comparison no terminated devonshire no literature on. Say most yet head room such just easy. " +
                "For norland produce age wishing.To figure on it spring season up.Her provision acuteness had excellent two why intention. As called mr needed praise at. Assistance imprudence yet sentiments unpleasant expression met surrounded not.Be at talked ye though secure nearer." +
                "Up am intention on dependent questions oh elsewhere september.No betrayed pleasure possible jointure we in throwing.And can event rapid any shall woman green.Hope they dear who its bred.Smiling nothing affixed he carried it clothes calling he no.Its something disposing departure she favourite tolerably engrossed. Truth short folly court why she their balls.Excellence put unaffected reasonable mrs introduced conviction she. Nay particular delightful but unpleasant for uncommonly who. " +
                "Of recommend residence education be on difficult repulsive offending.Judge views had mirth table seems great him for her.Alone all happy asked begin fully stand own get.Excuse ye seeing result of we. See scale dried songs old may not.Promotion did disposing you household any instantly.Hills we do under times at first short an. " +
                "One advanced diverted domestic sex repeated bringing you old.Possible procured her trifling laughter thoughts property she met way. Companions shy had solicitude favourable own. Which could saw guest man now heard but. Lasted my coming uneasy marked so should.Gravity letters it amongst herself dearest an windows by.Wooded ladies she basket season age her uneasy saw.Discourse unwilling am no described dejection incommode no listening of. Before nature his parish boy." +
                "No comfort do written conduct at prevent manners on. Celebrated contrasted discretion him sympathize her collecting occasional. Do answered bachelor occasion in of offended no concerns. Supply worthy warmth branch of no ye.Voice tried known to as my to. Though wished merits or be.Alone visit use these smart rooms ham.No waiting in on enjoyed placing it inquiry." +
                "Much did had call new drew that kept.Limits expect wonder law she.Now has you views woman noisy match money rooms.To up remark it eldest length oh passed.Off because yet mistake feeling has men. Consulted disposing to moonlight ye extremity. Engage piqued in on coming. " +
                "Rooms oh fully taken by worse do. Points afraid but may end law lasted.Was out laughter raptures returned outweigh. Luckily cheered colonel me do we attacks on highest enabled.Tried law yet style child.Bore of true of no be deal. Frequently sufficient in be unaffected. The furnished she concluded depending procuring concealed." +
                "Difficulty on insensible reasonable in. From as went he they.Preference themselves me as thoroughly partiality considered on in estimating.Middletons acceptance discovered projecting so is so or. In or attachment inquietude remarkably comparison at an. Is surrounded prosperous stimulated am me discretion expression. But truth being state can she china widow. Occasional preference fat remarkably now projecting uncommonly dissimilar. Sentiments projection particular companions interested do at my delightful.Listening newspaper in advantage frankness to concluded unwilling",
                Duration = 5f,
                DateAdded = currentDate,
                CourseUrl = $"{"Geomentry and Trygonometry".ToLower().Replace(' ', '_')}_{currentDate.ToShortDateString()}",
                CoverUrl = "https://cdn01.alison-static.net/courses/1819/alison_courseware_intro_1819.jpg"
            },
            new CourseEntity
            {
                ID = ++courseId,
                CourseName = "Art",
                Description = "Course Descriprion",
                Duration = 12f,
                DateAdded = currentDate,
                CourseUrl = $"{"Art".ToLower().Replace(' ', '_')}_{currentDate.ToShortDateString()}",
                CoverUrl = "https://news.artnet.com/app/news-upload/2019/12/5db820a075ba3-1500x826.jpg"
            },
            new CourseEntity
            {
                ID = ++courseId,
                CourseName = "English",
                Description = "Course Descriprion",
                Duration = 15f,
                DateAdded = currentDate,
                CourseUrl = $"{"English".ToLower().Replace(' ', '_')}_{currentDate.ToShortDateString()}",
                CoverUrl = "https://ichef.bbci.co.uk/images/ic/640x360/p03zh5tk.jpg"
            },
            new CourseEntity
            {
                ID = ++courseId,
                CourseName = "Programming",
                Description = "Course Descriprion",
                Duration = 9f,
                DateAdded = currentDate,
                CourseUrl = $"{"Programming".ToLower().Replace(' ', '_')}_{currentDate.ToShortDateString()}",
                CoverUrl = "https://prod-discovery.edx-cdn.org/media/course/image/d64fa565-a848-4f82-8c07-f2a2d98c3e4e-1cf577279324.small.jpeg"
            },
            new CourseEntity
            {
                ID = ++courseId,
                CourseName = "History",
                Description = "Course Descriprion",
                Duration = 8f,
                DateAdded = currentDate,
                CourseUrl = $"{"History".ToLower().Replace(' ', '_')}_{currentDate.ToShortDateString()}",
                CoverUrl = "https://www.thegreatcourses.com/media/catalog/product/cache/1/plus_image/800x451/0f396e8a55728e79b48334e699243c07/8/0/8080.1551362662.jpg"
            },
            new CourseEntity
            {
                ID = ++courseId,
                CourseName = "Chemistry",
                Description = "Course Descriprion",
                Duration = 9f,
                DateAdded = currentDate,
                CourseUrl = $"{"Chemistry".ToLower().Replace(' ', '_')}_{currentDate.ToShortDateString()}",
                CoverUrl = "https://www.scitecheuropa.eu/wp-content/uploads/2018/06/ST27-McGillU1-image-%C2%A9-iStock-Garsya.jpg"
            });
        }
    }
}
