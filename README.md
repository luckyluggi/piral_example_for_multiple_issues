# Intro
This repo serves as a demo for multiple issues.

# Repro Steps
- `cd ./appshell` and run `npm i` and then `npm run build`
- `cd ../LayoutPilet` and run `dotnet build`
- `cd ../ShopPilet` and run `dotnet build`
- `cd ../piral~/LayoutPilet` and run `pilet debug .\src\index.tsx ..\ShopPilet\src\index.tsx`


# Issues

## Issue regarding a single entry point per pilet
Open the route `/shop` an add some products to the cart. You'll see that the products are only added to the red cart, but not to the green one.

## Issue regarding extensions not beng rerendered when params change
Open the `/shop` page and toggle the "switch"-button in the topbar. 
This changes the boolean value in `LayoutPilet\Components\Topbar.razor` on line 23.
The value is passed to the Cart Extensions in the Topbar.Right extension-slot, but they are not updatet when this value changes.
