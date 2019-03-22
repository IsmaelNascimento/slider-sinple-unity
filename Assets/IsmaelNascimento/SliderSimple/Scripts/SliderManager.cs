using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace IsmaelNascimento
{
    public class SliderManager : MonoBehaviour
    {
        #region VARIABLES

        [SerializeField] private Button btnPrev;
        [SerializeField] private Image imgShow;
        [SerializeField] private Button btnNext;
        [Space(10)]
        [SerializeField] private List<Sprite> imagesForShow;
        private int indexImagesForShow;

        #endregion

        #region METHODS_MONOBEHAVIOUR

        private void Start()
        {
            btnPrev.onClick.AddListener(OnButtonPrevClicked);
            btnNext.onClick.AddListener(OnButtonNextClicked);
        }

        #endregion

        #region METHODS_PRIVATE

        private void OnButtonPrevClicked()
        {
            indexImagesForShow--;

            if (indexImagesForShow < 0)
            {
                indexImagesForShow = imagesForShow.Count - 1;
            }

            imgShow.sprite = imagesForShow[indexImagesForShow];
        }

        private void OnButtonNextClicked()
        {
            indexImagesForShow++;

            if (indexImagesForShow > imagesForShow.Count - 1)
            {
                indexImagesForShow = 0;
            }

            imgShow.sprite = imagesForShow[indexImagesForShow];
        }

        #endregion
    }
}