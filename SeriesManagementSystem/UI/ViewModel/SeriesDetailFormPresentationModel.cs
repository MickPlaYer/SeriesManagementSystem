using SeriesManagementSystem.Domain;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SeriesManagementSystem.UI.ViewModel
{
    public enum SeriesState
    {
        NotFollowed = 0,
        Followed,
        Unfollowed
    }

    public class SeriesDetailFormPresentationModel
    {
        Series _series;
        /// <summary>
        /// 0 代表沒有被follow過
        /// 1 代表正在被follow
        /// 2 代表已經follow過，但放棄
        /// </summary>
        SeriesState _seriesState = 0;

        public SeriesDetailFormPresentationModel(Series series)
        {
            _series = series;
        }

        public int EpisodeNumber
        {
            get
            {
                return _series.Episodes.Count;
            }
        }

        public string SeriesName
        {
            get
            {
                return _series.Name;
            }
        }

        public string SeriesDescription
        {
            get
            {
                return _series.Description;
            }
        }

        public void SetSeriesState(List<Series> followingList, List<Series> unfollowingList)
        {
            if (followingList.Exists(x => x == _series))
            {
                _seriesState = ViewModel.SeriesState.Followed;
            }
            else if (unfollowingList.Exists(x => x == _series))
            {
                _seriesState = ViewModel.SeriesState.Unfollowed;
            }
            else
            {
                _seriesState = ViewModel.SeriesState.NotFollowed;
            }
        }

        public string SeriesState
        {
            get
            {
                switch (_seriesState)
                {
                    case ViewModel.SeriesState.NotFollowed:
                        return "追蹤影集";
                    case ViewModel.SeriesState.Followed:
                        return "放棄影集";
                    default:
                        return "復原該影集";
                }
            }
        }

        public event FollowSeriesEventHandler FollowSeriesEvent;
        public delegate void FollowSeriesEventHandler();
        public event UnfollowSeriesEventHandler UnfollowSeriesEvent;
        public delegate void UnfollowSeriesEventHandler();
        public event RecoverSeriesEventHandler RecoverSeriesEvent;
        public delegate void RecoverSeriesEventHandler();

        public void MoveSeries()
        {
            switch (_seriesState)
            {
                case ViewModel.SeriesState.NotFollowed:
                    if (FollowSeriesEvent != null)
                    {
                        FollowSeriesEvent();
                        _seriesState = ViewModel.SeriesState.Followed;
                    }
                    break;
                case ViewModel.SeriesState.Followed:
                    if (UnfollowSeriesEvent != null)
                    {
                        UnfollowSeriesEvent();
                        _seriesState = ViewModel.SeriesState.Unfollowed;
                    }
                    break;
                default:
                    if (RecoverSeriesEvent != null)
                    {
                        RecoverSeriesEvent();
                        _seriesState = ViewModel.SeriesState.Followed;
                    }
                    break;
            }
        }

        public List<Command> GetCommands(string episodeName)
        {
            return _series.Episodes.Find((x) => x.Name == episodeName).CommandList;
        }
    }
}
