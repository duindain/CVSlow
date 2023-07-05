# CVSlow

Sample app with a collectionview page in that collectionview is a few controls, labels, images and a button and a border around them
Adding items to the list seems to have negligable performance impact

Navigating back to the main page then to the list page does have a significant performance impact
Repeating that navigation doesnt release the previous memory consumed

Even navigating back to the MainPage consumes a few more MB each time

Scrolling up and down the list also consumes more memory that isnt released though not as significant as during navigation
