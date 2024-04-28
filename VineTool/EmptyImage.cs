namespace UnityEngine.UI
{
    [RequireComponent(typeof(CanvasRenderer))]
    public class EmptyImage : MaskableGraphic, ILayoutElement
    {
        protected EmptyImage()
        {
            useLegacyMeshGeneration = false;
        }

        protected override void OnPopulateMesh(VertexHelper toFill)
        {
            toFill.Clear();
        }

        #region ILayoutElement接口
        public float minWidth { get { return 0; } }

        public float preferredWidth { get { return 0; } }

        public float flexibleWidth { get { return -1; } }

        public float minHeight { get { return 0; } }

        public float flexibleHeight { get { return -1; } }

        public float preferredHeight { get { return 0; } }

        public int layoutPriority { get { return 0; } }

        public void CalculateLayoutInputHorizontal() { }

        public void CalculateLayoutInputVertical() { }
        #endregion
    }
}
