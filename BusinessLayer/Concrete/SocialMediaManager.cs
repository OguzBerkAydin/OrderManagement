using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Entities;

namespace BusinessLayer.Concrete
{
    public class SocialMediaManager : ISocialMediaService
    {
        private readonly ISocialMediaDal _socialMediaDal;

        public SocialMediaManager(ISocialMediaDal socialMediaDal)
        {
            _socialMediaDal = socialMediaDal;
        }

        public void TAdd(SocialMedia entity)
        {
            _socialMediaDal.Add(entity);
        }

        public void TDelete(SocialMedia entity)
        {
            _socialMediaDal.Delete(entity);
        }

        public SocialMedia TGet(int id)
        {
            return _socialMediaDal.Get(id);
        }

        public List<SocialMedia> TGetAll()
        {
            return _socialMediaDal.GetAll();
        }

        public void TUpdate(SocialMedia entity)
        {
            _socialMediaDal.Update(entity);
        }
    }
}
