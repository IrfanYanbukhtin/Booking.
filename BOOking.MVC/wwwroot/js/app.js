document.addEventListener('DOMContentLoaded', function () {
    const loadMoreButton = document.querySelector('#loadMore')
    const bakuContainer = document.querySelector('#hotelrow')
    const bakuBoxes = bakuContainer.querySelectorAll('.box')
    const initialDisplayCount = 4
    let currentDisplayCount = initialDisplayCount

    function updateLoadMoreButton() {
        if (currentDisplayCount >= bakuBoxes.length) {
            loadMoreButton.textContent = 'Less'
        } else {
            loadMoreButton.textContent = 'All'
        }
    }

    function displaybakuBoxes(startIndex, endIndex) {
        for (let i = 0; i < bakuBoxes.length; i++) {
            if (i >= startIndex && i < endIndex) {
                bakuBoxes[i].style.display = 'block'
            } else {
                bakuBoxes[i].style.display = 'none'
            }
        }
    }

    function updateDisplayBasedOnCategory() {
        const selectedCategory = document.querySelector('#select_category').value
        let visibleCount = 0

        for (let i = 0; i < bakuBoxes.length; i++) {
            const partnerBox = bakuBoxes[i]
            const partnerCategory = partnerBox.getAttribute('data-category')

            if (selectedCategory === '' || selectedCategory === partnerCategory) {
                if (visibleCount < initialDisplayCount) {
                    partnerBox.style.display = 'block'
                    visibleCount++
                } else {
                    partnerBox.style.display = 'none'
                }
            }
        }

        updateLoadMoreButton()
    }

    loadMoreButton.addEventListener('click', function (event) {
        event.preventDefault()

        if (loadMoreButton.textContent === 'Less') {
            currentDisplayCount = initialDisplayCount
        } else {
            currentDisplayCount = bakuBoxes.length
        }

        displaybakuBoxes(0, currentDisplayCount)
        updateLoadMoreButton()
    })

    const selectCategory = document.querySelector('#select_category')
    selectCategory.addEventListener('change', function () {
        currentDisplayCount = initialDisplayCount
        updateDisplayBasedOnCategory()
        updateLoadMoreButton()
    })