
namespace OpenCvSharp
{
#if LANG_JP
    /// <summary>
    /// cvMatchContourTreesで用いる、類似度
    /// </summary>
#else
    /// <summary>
    /// Similarity measure (cvMatchContourTrees)
    /// </summary>
#endif
    public enum ContourTreesMatchMethod : int
    {
#if LANG_JP
        /// <summary>
        /// [CV_CONTOUR_TREES_MATCH_I1]
        /// </summary>
#else
        /// <summary>
        /// [CV_CONTOUR_TREES_MATCH_I1]
        /// </summary>
#endif
        I1 = CvConst.CV_CONTOUR_TREES_MATCH_I1,
    }
}